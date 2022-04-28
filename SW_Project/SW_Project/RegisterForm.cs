using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace SW_Project
{
    public partial class RegisterForm : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public RegisterForm()
        {
            
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select max(userid) from SpotifyUser";
            int maxId = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
            cmd.CommandText = "insert into SpotifyUser values (:id , :FirstName , :LastName , :UserName , :Password)";
            cmd.Parameters.Add("id", maxId);
            cmd.Parameters.Add("FirstName", FirstName_txtBox.Text);
            cmd.Parameters.Add("LastName",  LastName_txtBox.Text);
            cmd.Parameters.Add("UserName",  userName_txtBox.Text);
            cmd.Parameters.Add("Password",  password_txtBox.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Registeration Succeeded");
            }
            else
                MessageBox.Show("Registeration Failed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainMenuForm mainMenuForm = new mainMenuForm();
            this.Hide();
            mainMenuForm.ShowDialog();
            this.Close();
        }
    }
}
