using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_Project
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            UserLIb userLIb = new UserLIb();
            userLIb.SetParameterValue(0, Convert.ToInt32(LoggedUser.ODR[0]));
            crystalReportViewer1.ReportSource = userLIb;
        }
    }
}
