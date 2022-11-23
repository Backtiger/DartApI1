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

namespace Stockking
{
    public partial class frmtest : Form
    {
        DataTable dt;
        DBconnect db = new DBconnect();
        SetQuery SetQuery = new SetQuery();
        
        public frmtest()
        {
            string path = null;
            //string sql = "select * from dbo.손익계산서";
            InitializeComponent();
            SetCombo();
            Screenning_View();
            // ReadXML(path);

            // dt=  db.ExcuteDataAdapter(sql);
            // DtScreening.DataSource = dt;
        }

        public void Screenning_View()
        {
           
        }

        public void getJason(string c_key)
        {
            using (WebClient webClient = new WebClient())
            {
                var jason = webClient.DownloadString("https://opendart.fss.or.kr/api/corpCode.xml");
                webClient.OpenRead("https://opendart.fss.or.kr/api/corpCode.xml");
              
            }
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
            Dictionary<string, string> combodata = new Dictionary<string, string>();
            combodata.Add("11013", "1분기 보고서");
            combodata.Add("11012", "반기 보고서");
            combodata.Add("11014", "3분기 보고서");
            combodata.Add("11011", "사업 보고서");

            cboReport.DataSource = new BindingSource(combodata ,null);
            cboReport.DisplayMember = "Value";
            cboReport.ValueMember = "Key";

            cboYear.Items.Add("2015");
            cboYear.Items.Add("2016");
            cboYear.Items.Add("2017");
            cboYear.Items.Add("2018");
            cboYear.Items.Add("2019");
            cboYear.Items.Add("2020");
            cboYear.Items.Add("2021");
            cboYear.Items.Add("2022");

        }

        private void 데이터연동ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatasettingting frmData = new frmDatasettingting();
            frmData.ShowDialog();
        }
    }
}
