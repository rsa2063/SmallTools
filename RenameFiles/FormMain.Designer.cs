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
            this.rename = new System.Windows.Forms.Button();
            this.formatStr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pathDisplay = new System.Windows.Forms.TextBox();
            this.inputDesPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // choose
            // 
            this.choose.Font = new System.Drawing.Font("Noto Sans CJK SC Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose.Location = new System.Drawing.Point(26, 25);
            this.choose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(210, 74);
            this.choose.TabIndex = 0;
            this.choose.Text = "选择文件夹";
            this.choose.UseVisualStyleBackColor = true;
            this.choose.Click += new System.EventHandler(this.choose_Click);
            // 
            // rename
            // 
            this.rename.Location = new System.Drawing.Point(667, 111);
            this.rename.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(155, 76);
            this.rename.TabIndex = 2;
            this.rename.Text = "rename";
            this.rename.UseVisualStyleBackColor = true;
            this.rename.Click += new System.EventHandler(this.rename_Click);
            // 
            // formatStr
            // 
            this.formatStr.Location = new System.Drawing.Point(150, 126);
            this.formatStr.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.formatStr.Name = "formatStr";
            this.formatStr.Size = new System.Drawing.Size(460, 34);
            this.formatStr.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "format";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(42, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(750, 76);
            this.label2.TabIndex = 5;
            this.label2.Text = "example : test-{0:d2}.jpg   -> test-01.jpg test-02.jpg\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pathDisplay
            // 
            this.pathDisplay.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold);
            this.pathDisplay.Location = new System.Drawing.Point(256, 30);
            this.pathDisplay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pathDisplay.Multiline = true;
            this.pathDisplay.Name = "pathDisplay";
            this.pathDisplay.ReadOnly = true;
            this.pathDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.pathDisplay.Size = new System.Drawing.Size(566, 69);
            this.pathDisplay.TabIndex = 6;
            this.pathDisplay.Text = "...";
            // 
            // inputDesPath
            // 
            this.inputDesPath.Location = new System.Drawing.Point(150, 272);
            this.inputDesPath.Name = "inputDesPath";
            this.inputDesPath.Size = new System.Drawing.Size(558, 34);
            this.inputDesPath.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(858, 459);
            this.Controls.Add(this.inputDesPath);
            this.Controls.Add(this.pathDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formatStr);
            this.Controls.Add(this.rename);
            this.Controls.Add(this.choose);
            this.Font = new System.Drawing.Font("Noto Sans CJK SC Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormMain";
            this.Text = "Rename Files";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog chooseFolder;
        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.Button rename;
        private System.Windows.Forms.TextBox formatStr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pathDisplay;
        private System.Windows.Forms.TextBox inputDesPath;
    }
}

