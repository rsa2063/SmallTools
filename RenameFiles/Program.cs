using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameFiles {
    public class Program {
        static Program p = null;
        static Program getController() {
            if(p == null) {
                p = new Program();
            }
            return p;
        }
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain(getController()));
        }

        public bool RenameFiles(String desPath, String formatStr) {
            var files = System.IO.Directory.EnumerateFiles(desPath);
            if(formatStr.Length == 0) {
                formatStr = "{0}.jpg";
            }
            int count = 1;
            foreach(String fileName in files) {
                if (new System.IO.FileInfo(fileName).Length > 1024 * 75) {
                    System.IO.File.Move(fileName, System.IO.Path.Combine(desPath, String.Format(formatStr, count)));
                    count++;
                }
            }
            return true;
        }
    }
}
