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
namespace DartApI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();



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
        

            XmlDocument xml = new XmlDocument();

            xml.Load(path);
            //ds.ReadXmlSchema("C:\\Users\\cit\\Desktop\\corpCode\\CORPCODE.xml");
            //ds.ReadXml("C:\\Users\\cit\\Desktop\\corpCode\\CORPCODE.xml");

            XmlNodeList xmlList = xml.SelectNodes("/result/list"); //xml노드 셀렉 result 노드의 list노드들을 가져옴                     


            foreach (XmlNode xnl in xmlList)
            {
                if(!string.IsNullOrEmpty(xnl["stock_code"].InnerText))
                dataGridView1.Rows.Add(xnl["corp_code"].InnerText.ToString()                                    
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


        }

        private void button2_Click(object sender, EventArgs e)
        {
                                                            //초기 기업정보 xml 경로 세팅 로직
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();                            //파일찾는 화면 표기
            dialog.InitialDirectory = "C:\\\\";             //기본 경로 c드라이브 설정
            string path = dialog.FileName;                  //선택파일 경로 세팅

            ReadXML(path);                                  //xml가공 메서드에 경로 전달
        }
    }
}
