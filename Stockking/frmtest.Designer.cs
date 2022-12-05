namespace Stockking
{
    partial class frmtest
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DtScreening = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabStockName = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox17 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.TabMain.SuspendLayout();
            this.TabScreenning.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtScreening)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabStockName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1294, 24);
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
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(804, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "검색";
            this.button3.UseVisualStyleBackColor = true;
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
            this.TabMain.Size = new System.Drawing.Size(1294, 677);
            this.TabMain.TabIndex = 14;
            // 
            // TabScreenning
            // 
            this.TabScreenning.Controls.Add(this.tableLayoutPanel1);
            this.TabScreenning.Location = new System.Drawing.Point(4, 22);
            this.TabScreenning.Name = "TabScreenning";
            this.TabScreenning.Padding = new System.Windows.Forms.Padding(3);
            this.TabScreenning.Size = new System.Drawing.Size(1286, 651);
            this.TabScreenning.TabIndex = 1;
            this.TabScreenning.Text = "스크리닝";
            this.TabScreenning.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.23438F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.76563F));
            this.tableLayoutPanel1.Controls.Add(this.DtScreening, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 645);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DtScreening
            // 
            this.DtScreening.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtScreening.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtScreening.Location = new System.Drawing.Point(3, 3);
            this.DtScreening.Name = "DtScreening";
            this.DtScreening.RowTemplate.Height = 23;
            this.DtScreening.Size = new System.Drawing.Size(957, 639);
            this.DtScreening.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.comboBox17);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.comboBox16);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.comboBox15);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.comboBox14);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.comboBox13);
            this.panel1.Controls.Add(this.comboBox12);
            this.panel1.Controls.Add(this.comboBox11);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.comboBox10);
            this.panel1.Controls.Add(this.comboBox9);
            this.panel1.Controls.Add(this.comboBox8);
            this.panel1.Controls.Add(this.comboBox7);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboBox6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(966, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 639);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "영업이익";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(20, 169);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(61, 20);
            this.comboBox4.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "성장률";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "시가총액";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(105, 57);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(61, 20);
            this.comboBox3.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(21, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(61, 20);
            this.comboBox2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "재무비율";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "당기\r\n순이익";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(20, 216);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(61, 20);
            this.comboBox5.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "PER";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(78, 421);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(61, 20);
            this.comboBox6.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "ROE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 424);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 12);
            this.label12.TabIndex = 12;
            this.label12.Text = "FCF";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(155, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 13;
            this.label13.Text = "PBR";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 318);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 12);
            this.label14.TabIndex = 14;
            this.label14.Text = "ROA";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(78, 279);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(61, 20);
            this.comboBox7.TabIndex = 15;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(214, 279);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(61, 20);
            this.comboBox8.TabIndex = 16;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(78, 314);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(61, 20);
            this.comboBox9.TabIndex = 17;
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(214, 314);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(61, 20);
            this.comboBox10.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 468);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 19;
            this.label15.Text = "매출액";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(214, 421);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(61, 20);
            this.comboBox11.TabIndex = 20;
            // 
            // comboBox12
            // 
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Location = new System.Drawing.Point(78, 462);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(61, 20);
            this.comboBox12.TabIndex = 21;
            // 
            // comboBox13
            // 
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Location = new System.Drawing.Point(214, 462);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(61, 20);
            this.comboBox13.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 522);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 23;
            this.label16.Text = "운용지표";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 547);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 24);
            this.label17.TabIndex = 24;
            this.label17.Text = "재고자산\r\n회전률";
            // 
            // comboBox14
            // 
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Location = new System.Drawing.Point(78, 547);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(61, 20);
            this.comboBox14.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(155, 547);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 24);
            this.label18.TabIndex = 26;
            this.label18.Text = "매출채권\r\n회전률";
            // 
            // comboBox15
            // 
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Location = new System.Drawing.Point(214, 547);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(61, 20);
            this.comboBox15.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 28;
            this.label19.Text = "절대조건";
            // 
            // comboBox16
            // 
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Location = new System.Drawing.Point(78, 349);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(61, 20);
            this.comboBox16.TabIndex = 30;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 353);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 12);
            this.label20.TabIndex = 29;
            this.label20.Text = "OPM";
            // 
            // comboBox17
            // 
            this.comboBox17.FormattingEnabled = true;
            this.comboBox17.Location = new System.Drawing.Point(78, 589);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(61, 20);
            this.comboBox17.TabIndex = 32;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 592);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 12);
            this.label21.TabIndex = 31;
            this.label21.Text = "유동비율";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(103, 42);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 12);
            this.label22.TabIndex = 33;
            this.label22.Text = "매출액";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(243, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 23);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(181, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "초기화";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 704);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TabMain);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmtest";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabMain.ResumeLayout(false);
            this.TabScreenning.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtScreening)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabStockName.ResumeLayout(false);
            this.tabStockName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView DtScreening;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBox16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBox14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label22;
    }
}

