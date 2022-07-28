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

                MessageBox.Show(jason.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ReadXML();


        }
        /// <summary>
        /// xml파싱
        /// </summary>
        public void ReadXML()
        {
            string temp = "";

            XmlDocument xml = new XmlDocument();

            xml.Load("C:\\Users\\cit\\Desktop\\corpCode\\CORPCODE.xml");

            XmlNodeList xmlList = xml.SelectNodes("/result/list"); //xml노드 셀렉 result 노드의 list노드들을 가져옴                     

            foreach (XmlNode xnl in xmlList)
            {
                temp += xnl["corp_code"].InnerText;
                temp += xnl["corp_name"].InnerText;
                temp += xnl["stock_code"].InnerText;
                temp += xnl["modify_date"].InnerText;
                MessageBox.Show(temp);
                temp = null;

            }


        }
    }
}
