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
    public partial class LibraryForm : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        int libId;
        public LibraryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            this.Hide();
            homeForm.ShowDialog();
            this.Close();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void LibraryForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getLib";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("usernumber", Convert.ToInt32(LoggedUser.ODR[0]));
            cmd.Parameters.Add("libId", OracleDbType.Int32, ParameterDirection.Output);
            try
            {
                cmd.ExecuteNonQuery();
                libId =Convert.ToInt32(cmd.Parameters["libId"].Value.ToString());
            }
            catch
            {
                Console.WriteLine("No library found!");
                this.Close();
            }
            OracleCommand libcmd = new OracleCommand();
            libcmd.Connection = conn;
            libcmd.CommandText = "getsongs";
            libcmd.CommandType = CommandType.StoredProcedure;
            libcmd.Parameters.Add("id", libId);
            libcmd.Parameters.Add("songs", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = libcmd.ExecuteReader();
            while (dr.Read())
            {
                songslist.Items.Add(dr[1]+"   singer : "+ dr[2]+"  "+dr[3]+"  Album: "+ dr[4]);
            }

        }
    }
}
