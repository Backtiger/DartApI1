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
    public partial class frmMain : Form
    {
        DAL dal = new DAL();

        public frmMain()
        {
            InitializeComponent();
            //DGScreeening.DataSource = dal.SelectInCome();
        }

        private void 데이터연동ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataSetting frmData = new frmDataSetting();
            frmData.ShowDialog();
        }
    }
}
