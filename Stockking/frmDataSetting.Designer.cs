namespace Stockking
{
    partial class frmDatasettingting
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
            this.gbDatasetting = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkStockList = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdBS = new System.Windows.Forms.RadioButton();
            this.rdCF = new System.Windows.Forms.RadioButton();
            this.rdCE = new System.Windows.Forms.RadioButton();
            this.rdPL = new System.Windows.Forms.RadioButton();
            this.btnPath = new System.Windows.Forms.Button();
            this.LBoxPath = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbDatasetting.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbDatasetting);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 450);
            this.panel1.TabIndex = 0;
            // 
            // gbDatasetting
            // 
            this.gbDatasetting.AutoSize = true;
            this.gbDatasetting.Controls.Add(this.button1);
            this.gbDatasetting.Controls.Add(this.groupBox2);
            this.gbDatasetting.Controls.Add(this.groupBox1);
            this.gbDatasetting.Controls.Add(this.label1);
            this.gbDatasetting.Controls.Add(this.rdBS);
            this.gbDatasetting.Controls.Add(this.rdCF);
            this.gbDatasetting.Controls.Add(this.rdCE);
            this.gbDatasetting.Controls.Add(this.rdPL);
            this.gbDatasetting.Controls.Add(this.btnPath);
            this.gbDatasetting.Controls.Add(this.LBoxPath);
            this.gbDatasetting.Controls.Add(this.label2);
            this.gbDatasetting.Controls.Add(this.btnOK);
            this.gbDatasetting.Location = new System.Drawing.Point(12, 12);
            this.gbDatasetting.Name = "gbDatasetting";
            this.gbDatasetting.Size = new System.Drawing.Size(762, 400);
            this.gbDatasetting.TabIndex = 0;
            this.gbDatasetting.TabStop = false;
            this.gbDatasetting.Text = "데이터 세팅";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGetData);
            this.groupBox2.Location = new System.Drawing.Point(379, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 60);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "당일 증권 정보 ";
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(27, 20);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 23);
            this.btnGetData.TabIndex = 11;
            this.btnGetData.Text = "가져오기";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkStockList);
            this.groupBox1.Location = new System.Drawing.Point(379, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 44);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "기업리스트";
            // 
            // chkStockList
            // 
            this.chkStockList.AutoSize = true;
            this.chkStockList.Location = new System.Drawing.Point(18, 21);
            this.chkStockList.Name = "chkStockList";
            this.chkStockList.Size = new System.Drawing.Size(84, 16);
            this.chkStockList.TabIndex = 0;
            this.chkStockList.Text = "종목리스트";
            this.chkStockList.UseVisualStyleBackColor = true;
            this.chkStockList.CheckedChanged += new System.EventHandler(this.chkStockList_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "데이터 구분";
            // 
            // rdBS
            // 
            this.rdBS.AutoSize = true;
            this.rdBS.Location = new System.Drawing.Point(379, 119);
            this.rdBS.Name = "rdBS";
            this.rdBS.Size = new System.Drawing.Size(83, 16);
            this.rdBS.TabIndex = 8;
            this.rdBS.TabStop = true;
            this.rdBS.Text = "자본변동표";
            this.rdBS.UseVisualStyleBackColor = true;
            // 
            // rdCF
            // 
            this.rdCF.AutoSize = true;
            this.rdCF.Location = new System.Drawing.Point(379, 97);
            this.rdCF.Name = "rdCF";
            this.rdCF.Size = new System.Drawing.Size(83, 16);
            this.rdCF.TabIndex = 7;
            this.rdCF.TabStop = true;
            this.rdCF.Text = "현금흐름표";
            this.rdCF.UseVisualStyleBackColor = true;
            // 
            // rdCE
            // 
            this.rdCE.AutoSize = true;
            this.rdCE.Location = new System.Drawing.Point(379, 75);
            this.rdCE.Name = "rdCE";
            this.rdCE.Size = new System.Drawing.Size(83, 16);
            this.rdCE.TabIndex = 6;
            this.rdCE.TabStop = true;
            this.rdCE.Text = "재무상태표";
            this.rdCE.UseVisualStyleBackColor = true;
            // 
            // rdPL
            // 
            this.rdPL.AutoSize = true;
            this.rdPL.Location = new System.Drawing.Point(379, 53);
            this.rdPL.Name = "rdPL";
            this.rdPL.Size = new System.Drawing.Size(83, 16);
            this.rdPL.TabIndex = 5;
            this.rdPL.TabStop = true;
            this.rdPL.Text = "손익계산서";
            this.rdPL.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDatasettingting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmDatasettingting";
            this.Text = "frmDatasettingting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbDatasetting.ResumeLayout(false);
            this.gbDatasetting.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbDatasetting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox LBoxPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdBS;
        private System.Windows.Forms.RadioButton rdCF;
        private System.Windows.Forms.RadioButton rdCE;
        private System.Windows.Forms.RadioButton rdPL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkStockList;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}