using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using Stockking.GET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stockking
{
    public partial class frmtest : Form
    {
        DataTable dt;
        DBconnect db = new DBconnect();
        SetQuery SetQuery = new SetQuery();

        GetFacturing GetFacturing = new GetFacturing();

        public frmtest()
        {   
            InitializeComponent();
            SetCombo();
            GetFacturing.ALLDATA();

            MakeCboGrid(DgCondition);
            // ReadXML(path);

            // dt=  db.ExcuteDataAdapter(sql);
            // DtScreening.DataSource = dt;
        }
    
        private void button1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// xml파싱
        /// </summary>
        public void ReadXML(string path)
        {
            string temp = "";

            path = "C:\\\\Users\\\\cit\\\\Desktop\\\\corpCode\\\\CORPCODE.xml";
            XmlDocument xml = new XmlDocument();
            xml.Load(path);
            SetQuery SetQuery = new SetQuery();
            

           // DataTable dt = new DataTable();
            //System.IO.FileStream stream =  new System.IO.FileStream(path, System.IO.FileMode.Open);          
           
            //dt.ReadXmlSchema(stream);
            //stream.Close();

            //ds.ReadXmlSchema("C:\\Users\\cit\\Desktop\\corpCode\\CORPCODE.xml");
            //ds.ReadXml("C:\\Users\\cit\\Desktop\\corpCode\\CORPCODE.xml");

            XmlNodeList xmlList = xml.SelectNodes("/result/list"); //xml노드 셀렉 result 노드의 list노드들을 가져옴                     


            foreach (XmlNode xnl in xmlList)
            {
                if (!string.IsNullOrEmpty(xnl["stock_code"].InnerText))
                    dataGridView1.Rows.Add(xnl["corp_code"].InnerText.ToString()
                                         , xnl["corp_name"].InnerText.ToString()
                                         , xnl["stock_code"].InnerText.ToString()
                                         , xnl["modify_date"].InnerText.ToString());
                SetQuery.Insert_stockList(xnl["corp_code"].InnerText.ToString()
                                    , xnl["corp_name"].InnerText.ToString()
                                    , xnl["stock_code"].InnerText.ToString()
                                    , xnl["modify_date"].InnerText.ToString());

                //temp += xnl["corp_code"].InnerText;
                //temp += xnl["corp_code"].InnerText;
                //temp += xnl["corp_name"].InnerText;
                //temp += xnl["stock_code"].InnerText;
                //temp += xnl["modify_date"].InnerText;
                //MessageBox.Show(temp);
                //temp = null;
            }

            //foreach (DataRow row in dt.Rows)
            //{
            //    MessageBox.Show(row[0].ToString());
                
            //}
           
            //dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {                                                          
            OpenFileDialog dialog = new OpenFileDialog();  //초기 기업정보 xml 경로 세팅 로직
            dialog.ShowDialog();                            //파일찾는 화면 표기
            dialog.InitialDirectory = "C\\\\";              //기본 경로 c드라이브 설정
            string path = dialog.FileName;                  //선택파일 경로 세팅

            ReadXML(path);                                  //xml가공 메서드에 경로 전달
        }
        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmfinancial fin = new frmfinancial(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString()
                                               ,cboYear.SelectedItem.ToString()
                                               ,cboReport.SelectedValue.ToString());
            fin.ShowDialog();
        }

        public void SetCombo()
        {
            cboperiod.Items.Add("전체 년도 평균");
            cboperiod.Items.Add("최근 4분기 평균");
            cboperiod.Items.Add("전기 대비");
            cboperiod.Items.Add("전년 대비");


            Dictionary<string, string> combodata = new Dictionary<string, string>();
            combodata.Add("11013", "1분기 보고서");
            combodata.Add("11012", "반기 보고서");
            combodata.Add("11014", "3분기 보고서");
            combodata.Add("11011", "사업 보고서");

            cboReport.DataSource = new BindingSource(combodata ,null);
            cboReport.DisplayMember = "Value";
            cboReport.ValueMember = "Key";

        }

        private void 데이터연동ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatasettingting frmData = new frmDatasettingting();
            frmData.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {            
            DgScreening.DataSource= GetFacturing.Calculation();
        }


        private void MakeCboGrid(DataGridView gridView)
        {
            DataGridViewComboBoxCell cbocell = new DataGridViewComboBoxCell();
            DataGridViewComboBoxCell cbocell2 = new DataGridViewComboBoxCell();
            cbocell.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;


            foreach (var enumlist in Enum.GetValues(typeof(GetFacturing.incomeitemstat))) {

                cbocell.Items.Add(enumlist);
            }
           
            gridView.Rows.Insert(gridView.Rows.Count);

            int NowRowIndex = gridView.Rows.Count - 1;

            gridView.Rows[NowRowIndex].Cells[3].ReadOnly = true;
            gridView.Rows[NowRowIndex].Cells[3].Style.BackColor = Color.Gray;


            gridView.Rows[NowRowIndex].Cells[0] = cbocell;
            gridView.Rows[NowRowIndex].Cells[0].Value = cbocell.Items[0];

            foreach (string item in GetFacturing.equalsign)
            {
                cbocell2.Items.Add(item);
            }

            gridView.Rows[NowRowIndex].Cells[1] = cbocell2;
            gridView.Rows[NowRowIndex].Cells[1].Value = cbocell2.Items[0];

            
        }

        private void btn_AddLine_Click(object sender, EventArgs e)
        {
            MakeCboGrid(DgCondition);
        }         

        private void DgCondition_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void DgCondition_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            System.Windows.Forms.ComboBox combo = e.Control as System.Windows.Forms.ComboBox;
            
            if (combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
                combo.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
            String item = cb.Text;
            int Rowindex = DgCondition.CurrentCell.RowIndex;

            if (item == "~")
            {
                DgCondition.Rows[Rowindex].Cells[3].ReadOnly = false;
                DgCondition.Rows[Rowindex].Cells[3].Style.BackColor = Color.White;
            }
            else
            {
                DgCondition.Rows[Rowindex].Cells[3].Value = null;
                DgCondition.Rows[Rowindex].Cells[3].ReadOnly = true;
                DgCondition.Rows[Rowindex].Cells[3].Style.BackColor = Color.Gray;
            }     
        }

    
    }
}
