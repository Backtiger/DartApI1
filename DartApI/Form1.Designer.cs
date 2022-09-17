namespace DartApI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboReport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.데이터연동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TabMain = new System.Windows.Forms.TabControl();
            this.TabScreenning = new System.Windows.Forms.TabPage();
            this.tabStockName = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.TabMain.SuspendLayout();
            this.TabScreenning.SuspendLayout();
            this.tabStockName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(699, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "리스트파일오픈";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(687, 121);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(121, 20);
            this.cboYear.TabIndex = 3;
            // 
            // cboReport
            // 
            this.cboReport.FormattingEnabled = true;
            this.cboReport.Location = new System.Drawing.Point(687, 183);
            this.cboReport.Name = "cboReport";
            this.cboReport.Size = new System.Drawing.Size(121, 20);
            this.cboReport.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "년도 선택";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(685, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "보고서 선택";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1169, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.데이터연동ToolStripMenuItem});
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sToolStripMenuItem.Text = "설정";
            // 
            // 데이터연동ToolStripMenuItem
            // 
            this.데이터연동ToolStripMenuItem.Name = "데이터연동ToolStripMenuItem";
            this.데이터연동ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.데이터연동ToolStripMenuItem.Text = "데이터 연동";
            this.데이터연동ToolStripMenuItem.Click += new System.EventHandler(this.데이터연동ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(687, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "기업명 검색";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(804, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "검색";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(687, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "보고서 선택";
            // 
            // TabMain
            // 
            this.TabMain.Controls.Add(this.TabScreenning);
            this.TabMain.Controls.Add(this.tabStockName);
            this.TabMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabMain.Location = new System.Drawing.Point(0, 27);
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(1169, 677);
            this.TabMain.TabIndex = 14;
            // 
            // TabScreenning
            // 
            this.TabScreenning.Controls.Add(this.tableLayoutPanel1);
            this.TabScreenning.Location = new System.Drawing.Point(4, 22);
            this.TabScreenning.Name = "TabScreenning";
            this.TabScreenning.Padding = new System.Windows.Forms.Padding(3);
            this.TabScreenning.Size = new System.Drawing.Size(1161, 651);
            this.TabScreenning.TabIndex = 1;
            this.TabScreenning.Text = "스크리닝";
            this.TabScreenning.UseVisualStyleBackColor = true;
            // 
            // tabStockName
            // 
            this.tabStockName.Controls.Add(this.button3);
            this.tabStockName.Controls.Add(this.label4);
            this.tabStockName.Controls.Add(this.label3);
            this.tabStockName.Controls.Add(this.dataGridView1);
            this.tabStockName.Controls.Add(this.textBox1);
            this.tabStockName.Controls.Add(this.comboBox1);
            this.tabStockName.Controls.Add(this.button1);
            this.tabStockName.Controls.Add(this.label1);
            this.tabStockName.Controls.Add(this.label2);
            this.tabStockName.Controls.Add(this.cboYear);
            this.tabStockName.Controls.Add(this.button2);
            this.tabStockName.Controls.Add(this.cboReport);
            this.tabStockName.Location = new System.Drawing.Point(4, 22);
            this.tabStockName.Name = "tabStockName";
            this.tabStockName.Padding = new System.Windows.Forms.Padding(3);
            this.tabStockName.Size = new System.Drawing.Size(1161, 651);
            this.tabStockName.TabIndex = 0;
            this.tabStockName.Text = "종목리스트";
            this.tabStockName.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(30, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(544, 549);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.21645F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.78355F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1155, 645);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(805, 637);
            this.dataGridView2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 704);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TabMain);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabMain.ResumeLayout(false);
            this.TabScreenning.ResumeLayout(false);
            this.tabStockName.ResumeLayout(false);
            this.tabStockName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ComboBox cboReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem 데이터연동ToolStripMenuItem;
        private System.Windows.Forms.TabControl TabMain;
        private System.Windows.Forms.TabPage TabScreenning;
        private System.Windows.Forms.TabPage tabStockName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

