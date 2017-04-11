namespace RenameFiles {
    partial class FormMain {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.chooseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.choose = new System.Windows.Forms.Button();
            this.pathDisplay = new System.Windows.Forms.Label();
            this.rename = new System.Windows.Forms.Button();
            this.formatStr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // choose
            // 
            this.choose.Location = new System.Drawing.Point(71, 36);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(153, 41);
            this.choose.TabIndex = 0;
            this.choose.Text = "choose folder";
            this.choose.UseVisualStyleBackColor = true;
            this.choose.Click += new System.EventHandler(this.choose_Click);
            // 
            // pathDisplay
            // 
            this.pathDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pathDisplay.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathDisplay.Location = new System.Drawing.Point(239, 36);
            this.pathDisplay.Name = "pathDisplay";
            this.pathDisplay.Size = new System.Drawing.Size(533, 41);
            this.pathDisplay.TabIndex = 1;
            this.pathDisplay.Text = "...";
            this.pathDisplay.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // rename
            // 
            this.rename.Location = new System.Drawing.Point(659, 133);
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(113, 43);
            this.rename.TabIndex = 2;
            this.rename.Text = "rename";
            this.rename.UseVisualStyleBackColor = true;
            this.rename.Click += new System.EventHandler(this.rename_Click);
            // 
            // formatStr
            // 
            this.formatStr.Location = new System.Drawing.Point(148, 144);
            this.formatStr.Name = "formatStr";
            this.formatStr.Size = new System.Drawing.Size(469, 25);
            this.formatStr.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "format";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(71, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(546, 43);
            this.label2.TabIndex = 5;
            this.label2.Text = "example : test-{0}.jpg   -> test-1.jpg test-2.jpg\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formatStr);
            this.Controls.Add(this.rename);
            this.Controls.Add(this.pathDisplay);
            this.Controls.Add(this.choose);
            this.Name = "FormMain";
            this.Text = "Rename Files";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog chooseFolder;
        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.Label pathDisplay;
        private System.Windows.Forms.Button rename;
        private System.Windows.Forms.TextBox formatStr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

