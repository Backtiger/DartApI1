using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            dialog.Title = "벌크파일경로 세팅";
            dialog.Filter = "그림 파일 (*.txt, *.cvs) 모든 파일 (*.*) | *.*";

            //다중선택가능
            dialog.Multiselect = true;
            //파일 오픈창 로드
            DialogResult dr = dialog.ShowDialog();

            //OK버튼 클릭시
            if (dr == DialogResult.OK)
            {
                foreach (string FileName in dialog.SafeFileNames)
                {
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
            dal.SelectInCome();
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

            if (rdBS.Checked) //재무상태
                dbName = "dbo.stFinacial";
            if (rdPL.Checked) //손익계산
                dbName = "dbo.stFinacial";
            if (rdCE.Checked) //자본변동
                dbName = "dbo.changeEquity";
            if (rdCF.Checked) //현금흐름
                dbName = "dbo.cashFlow";

            foreach (string rw in LBoxPath.Items) 
            {
               flag = dal.Bulkinsert_IncomeStatement(rw,dbName);
                if (flag > 0) 
                {
                    MessageBox.Show("데이터가 생성되었습니다.");
                }                
            }
        }
    }
}
