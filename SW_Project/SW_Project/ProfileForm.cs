using Oracle.DataAccess.Client;
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
    public partial class ProfileForm : Form
    {
        string constr = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleDataAdapter adapter;
        OracleCommandBuilder commandBuilder;
        DataSet ds;

        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            string cmdstr = "Select * from spotifyuser where userid = "+ LoggedUser.ODR[0];

            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            profileGrid.DataSource = ds.Tables[0];
            profileGrid.Columns["userid"].Visible = false;
            profileGrid.Columns["username"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            commandBuilder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            this.Close();
        }

       private void profileGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Visible = true;
        }



    }
}
