package util;

import java.io.File;
import java.io.FileInputStream;
import java.security.MessageDigest;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.Base64;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.TimeUnit;

public class HashFiles {

    static ExecutorService pool = Executors.newFixedThreadPool(20);
    volatile static int fileNum = 0;
    volatile static int errFileNum = 0;

    static Connection c = null;
    static Statement stmt = null;
    static PreparedStatement stmtPre = null;
    static MessageDigest md = null;

    public void walkFiles(String path) {
        File[] children = new File(path).listFiles();
        if (children == null) {
            return;
        }
        for (File f : new File(path).listFiles()) {
            if (f.isDirectory()) {
                walkFiles(f.getAbsolutePath());
            } else if (f.isFile()) {
                fileNum++;
                pool.submit(new Runnable() {

                    @Override
                    public void run() {
                        byte[] data = new byte[65536];
                        try {
                            FileInputStream inputStream = new FileInputStream(f);
                            int count = inputStream.read(data);
                            inputStream.close();

                            md = MessageDigest.getInstance("MD5");
                            // System.out.println(f.getAbsolutePath());
                            String hash = Base64.getEncoder().encodeToString(md.digest(data));
                            // System.out.println(f.getAbsolutePath() + "\n" +
                            // hash);
                            // System.out.println(new String(data));
                            synchronized (stmtPre) {
                                stmtPre.setString(1, hash);
                                stmtPre.setString(2, f.getAbsolutePath());
                                stmtPre.execute();
                            }
                        } catch (Exception e) {
                            System.err.println(e);
                            errFileNum++;
                        }
                    }
                });
            }
        }
    }

    public static void main(String[] args) {
        try {
            // get db connection
            Class.forName("org.sqlite.JDBC");
            c = DriverManager.getConnection("jdbc:sqlite:data/test.sqlite");
            System.out.println("Opened database successfully");

            String sql;
            stmt = c.createStatement();

            switch (args[0]) {
                case "clear":
                    sql = "delete from hashFile";
                    stmt.executeUpdate(sql);
                    stmt.close();
                    break;
                case "add":
                    if (args[1] == null || args[1].length() == 0) {
                        break;
                    }
                    // create table
                    sql = "CREATE TABLE IF NOT EXISTS hashFile ( hash TEXT , path TEXT primary key)";
                    stmt.executeUpdate(sql);
                    sql = "CREATE index  IF NOT EXISTS iHash on hashFile(hash)";
                    stmt.executeUpdate(sql);
                    stmt.close();

                    String sqlInsert = "insert into hashFile (hash, path) values (?, ?)";
                    stmtPre = c.prepareStatement(sqlInsert);

                    // loop files
                    new HashFiles().walkFiles(args[1]);
                    pool.shutdown();
                    try {
                        pool.awaitTermination(5, TimeUnit.HOURS);
                    } catch (InterruptedException e) {
                        e.printStackTrace();
                    }
                    System.out.println("--sum: " + fileNum);
                    System.out.println("--err: " + errFileNum);

                    stmt = c.createStatement();
                    ResultSet rs = stmt.executeQuery("SELECT count(*) FROM hashFile;");
                    if (rs.next()) {
                        System.out.println("db num is " + rs.getInt(1));
                    }
                case "find":
                    rs = stmt.executeQuery(
                            "select hash,group_concat(path, '\n') as file from hashFile group by hash having count(hash) > 1 order by file");
                    System.out.println("start");
                    while (rs.next()) {
                        System.out.println("*********************************************************************");
                        System.out.println(rs.getString(1));
                        System.out.println(rs.getString(2));
                    }
                    System.out.println("*********************************************************************");
                    System.out.println("end");
            }

            stmt.close();
            c.close();
        } catch (Exception e) {
            System.err.println(e.getClass().getName() + ": " + e.getMessage());
            e.printStackTrace();
            System.exit(0);
        }
    }
}
