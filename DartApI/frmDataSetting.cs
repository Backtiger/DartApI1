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

                return filelist;
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

        }
    }
}
