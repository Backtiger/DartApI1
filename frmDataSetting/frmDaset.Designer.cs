namespace frmDataSetting
{
    partial class frmDaset
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.GBdatset = new System.Windows.Forms.GroupBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPath = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.GBdatset.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.GBdatset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 525);
            this.panel1.TabIndex = 0;
            // 
            // GBdatset
            // 
            this.GBdatset.AutoSize = true;
            this.GBdatset.Controls.Add(this.lbPath);
            this.GBdatset.Controls.Add(this.label1);
            this.GBdatset.Controls.Add(this.btnPath);
            this.GBdatset.Location = new System.Drawing.Point(30, 22);
            this.GBdatset.Name = "GBdatset";
            this.GBdatset.Size = new System.Drawing.Size(630, 475);
            this.GBdatset.TabIndex = 0;
            this.GBdatset.TabStop = false;
            this.GBdatset.Text = "데이터넣기";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(497, 40);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 0;
            this.btnPath.Text = "경로설정";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "파일경로";
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(132, 40);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(38, 12);
            this.lbPath.TabIndex = 2;
            this.lbPath.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(686, 525);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "데이터연동";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GBdatset.ResumeLayout(false);
            this.GBdatset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GBdatset;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPath;
    }
}

