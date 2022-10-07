using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDataSetting
{
    public partial class frmDaset : Form
    {
        public frmDaset()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public String FilePath()
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "벌크파일경로 세팅";          
            dialog.Filter = "그림 파일 (*.txt, *.cvs) 모든 파일 (*.*) | *.*";

            //파일 오픈창 로드
            DialogResult dr = dialog.ShowDialog();

            //OK버튼 클릭시
            if (dr == DialogResult.OK)
            {
                //File명과 확장자를 가지고 온다.
                string fileName = dialog.SafeFileName;
                //File경로와 File명을 모두 가지고 온다.
                string fileFullName = dialog.FileName;



                return fileFullName;
            }
            //취소버튼 클릭시 또는 ESC키로 파일창을 종료 했을경우
            else if (dr == DialogResult.Cancel)
            {
                return "";
            }

            return "";

        }






        private void btnPath_Click(object sender, EventArgs e)
        {
            FilePath();
        }





    }
    
}
