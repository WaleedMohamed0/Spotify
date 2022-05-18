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
            OracleCommand usercmd = new OracleCommand();
            OracleCommand libcmd = new OracleCommand();

            usercmd.Connection = conn;
            libcmd.Connection = conn;
            usercmd.CommandText = "select max(userid) from SpotifyUser";
            int maxId = Convert.ToInt32(usercmd.ExecuteScalar()) + 1;
            usercmd.CommandText = "insert into SpotifyUser values (:id , :FirstName , :LastName , :UserName , :Password)";
            usercmd.Parameters.Add("id", maxId);
            usercmd.Parameters.Add("FirstName", FirstName_txtBox.Text);
            usercmd.Parameters.Add("LastName",  LastName_txtBox.Text);
            usercmd.Parameters.Add("UserName",  userName_txtBox.Text);
            usercmd.Parameters.Add("Password",  password_txtBox.Text);
            try
            {
                int r = usercmd.ExecuteNonQuery();
                if (r != -1)
                {
                    libcmd.CommandText = "select max(lib_id) from userlibrary";
                    int libmax = Convert.ToInt32(libcmd.ExecuteScalar()) + 1;
                    libcmd.CommandText = "insert into  userlibrary values (:id , :uesrid)";
                    libcmd.Parameters.Add("id", libmax);
                    libcmd.Parameters.Add("userid", maxId);
                    libcmd.ExecuteNonQuery();
                    MessageBox.Show("Registeration Succeeded");
                }
                else
                    MessageBox.Show("Registeration Failed");

                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Enter missing data");
            }
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
