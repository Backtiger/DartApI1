namespace DartApI
{
    partial class frmDataSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbDataset = new System.Windows.Forms.GroupBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.LBoxPath = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbDataset.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbDataset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // gbDataset
            // 
            this.gbDataset.AutoSize = true;
            this.gbDataset.Controls.Add(this.btnPath);
            this.gbDataset.Controls.Add(this.LBoxPath);
            this.gbDataset.Controls.Add(this.label2);
            this.gbDataset.Controls.Add(this.btnOK);
            this.gbDataset.Location = new System.Drawing.Point(12, 12);
            this.gbDataset.Name = "gbDataset";
            this.gbDataset.Size = new System.Drawing.Size(762, 400);
            this.gbDataset.TabIndex = 0;
            this.gbDataset.TabStop = false;
            this.gbDataset.Text = "데이터 세팅";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(101, 355);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 4;
            this.btnPath.Text = "파일선택";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // LBoxPath
            // 
            this.LBoxPath.FormattingEnabled = true;
            this.LBoxPath.ItemHeight = 12;
            this.LBoxPath.Location = new System.Drawing.Point(101, 38);
            this.LBoxPath.Name = "LBoxPath";
            this.LBoxPath.Size = new System.Drawing.Size(199, 304);
            this.LBoxPath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "파일경로";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(225, 355);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmDataSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmDataSetting";
            this.Text = "frmDataSetting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbDataset.ResumeLayout(false);
            this.gbDataset.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbDataset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox LBoxPath;
        private System.Windows.Forms.Button btnPath;
    }
}