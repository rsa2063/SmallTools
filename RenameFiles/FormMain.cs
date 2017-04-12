using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameFiles {
    public partial class FormMain : Form {
        Program p;
        String desPath = "";

        public FormMain(Program p) {
            InitializeComponent();
            this.p = p;
        }

        private void FormMain_Load(object sender, EventArgs e) {
            if (p.IsWindows10()) {
                desPath = p.GetWallPaperDirectory();
                pathDisplay.Text = desPath;
            }
        }

        private void choose_Click(object sender, EventArgs e) {
            //if(desPath.Length > 0) {
            //    chooseFolder.SelectedPath = desPath;
            //}
            if(chooseFolder.ShowDialog() == DialogResult.OK) {
                desPath = chooseFolder.SelectedPath;
                pathDisplay.Text = desPath;

                String doc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                doc = doc.Substring(0, doc.LastIndexOf("\\"));
            }
        }

        private void rename_Click(object sender, EventArgs e) {
            try {
                if(p.RenameFiles(desPath, formatStr.Text)) {
                    MessageBox.Show("rename successfullly");
                }
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
