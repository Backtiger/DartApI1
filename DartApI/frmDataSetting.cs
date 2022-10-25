using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DartApI
{
    public partial class frmDataSetting : Form
    {
        DAL dal = new DAL();


        public frmDataSetting()
        {
            InitializeComponent();
        }

        public List<String> FilePath()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            List<String> filelist = new List<string>();

            //인코딩 변경 관련 변수선언
            int euckrCodepage = 51949;
            System.Text.Encoding utf8 = System.Text.Encoding.UTF8;
            System.Text.Encoding euckr = System.Text.Encoding.GetEncoding(euckrCodepage);
            int line = 0;
            string[] readText;
            string curLine;
            byte[] utf8Bytes;
            string decodedStringByUTF8;

            dialog.Title = "벌크파일경로 세팅";
            dialog.Filter = "그림 파일 (*.txt, *.cvs) 모든 파일 (*.*) | *.*";

            //다중선택가능
            dialog.Multiselect = true;
            //파일 오픈창 로드
            DialogResult dr = dialog.ShowDialog();

            //OK버튼 클릭시
            
            if (dr == DialogResult.OK)
            {

                foreach (string FileName in dialog.FileNames)
                {
                    //txt파일만 utf-8로 인코딩 변경되게끔
                    if (!FileName.Contains("xml"))
                    {
                        // //인코딩 utf-8로변경 후 저장하는로직
                        readText = File.ReadAllLines(FileName, euckr);
                        line = readText.Length;

                        for (int i = 0; i < line; i++)
                        {
                            curLine = readText[i];
                            utf8Bytes = utf8.GetBytes(curLine);
                            decodedStringByUTF8 = utf8.GetString(utf8Bytes);
                            readText[i] = decodedStringByUTF8;
                        }


                        File.WriteAllLines(FileName, readText, Encoding.UTF8);
                    }
                    filelist.Add(FileName);
                }
            }
            //취소버튼 클릭시 또는 ESC키로 파일창을 종료 했을경우
            else if (dr == DialogResult.Cancel)
            {
                return filelist;
            }

            return filelist;

        }

        public void Bulkinsert()
        {
            // dal.SelectInCome();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            List<String> path = null;

            path = FilePath();
            LBoxPath.DataSource = path;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int flag;
            string dbName = null;
            if (!chkStockList.Checked)
            {
                if (rdBS.Checked) //재무상태
                    dbName = "dbo.stFinacial";
                if (rdPL.Checked) //손익계산
                    dbName = "dbo.InComeStatement";
                if (rdCE.Checked) //자본변동
                    dbName = "dbo.changeEquity";
                if (rdCF.Checked) //현금흐름
                    dbName = "dbo.cashFlow";
            }


            foreach (string rw in LBoxPath.Items)
            {
                if (chkStockList.Checked == true)
                {
                   flag = ReadXML(rw);
                }
                else
                {
                    flag = dal.Bulkinsert_IncomeStatement(rw, dbName);
         
                }
                if (flag > 0)
                {
                    MessageBox.Show(rw + "데이터가 생성되었습니다.");
                }
            }


            LBoxPath.DataSource = null;
        }
        //기업리스트 xml파일 넣는 로직
        public int ReadXML(string path)
        {
            int rt = 0;
            
            XmlDocument xml = new XmlDocument();
            xml.Load(path);      

            XmlNodeList xmlList = xml.SelectNodes("/result/list"); //xml노드 셀렉 result 노드의 list노드들을 가져옴                     


            foreach (XmlNode xnl in xmlList)
            {
                if (!string.IsNullOrEmpty(xnl["stock_code"].InnerText))
                   rt= dal.Insert_stockList(xnl["corp_code"].InnerText.ToString()
                                        , xnl["corp_name"].InnerText.ToString()
                                        , xnl["stock_code"].InnerText.ToString()
                                        , xnl["modify_date"].InnerText.ToString());
            }
            return rt;
        }
        public void ChangeUTF(string FileName)
        {   
            //인코딩 변경 관련 변수선언
            int euckrCodepage = 51949;
            System.Text.Encoding utf8 = System.Text.Encoding.UTF8;
            System.Text.Encoding euckr = System.Text.Encoding.GetEncoding(euckrCodepage);
            int line = 0;
            string[] readText;
            string curLine;
            byte[] utf8Bytes;
            string decodedStringByUTF8;

            //인코딩 utf-8로변경 후 저장하는로직
            readText = File.ReadAllLines(FileName, euckr);
            line = readText.Length;

            for (int i = 0; i < line; i++)
            {
                curLine = readText[i];
                utf8Bytes = utf8.GetBytes(curLine);
                decodedStringByUTF8 = utf8.GetString(utf8Bytes);
                readText[i] = decodedStringByUTF8;
            }

            File.WriteAllLines(FileName, readText, Encoding.UTF8);
        }

        private void chkStockList_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStockList.Checked)
            {
                rdBS.Checked = false;
                rdCE.Checked = false;
                rdCF.Checked = false;
                rdPL.Checked = false;
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ToDayStockData();
        }
    }
}
