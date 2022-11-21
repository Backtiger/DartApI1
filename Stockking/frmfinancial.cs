using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stockking
{
    public partial class frmfinancial : Form
    {
        Datasetting ds = new Datasetting();
        public frmfinancial(string corpscode,string year,string report)
        {
            InitializeComponent();
            dataGridView1.DataSource=ds.Getmulticorps(corpscode,year,report);

        }
    }
}
