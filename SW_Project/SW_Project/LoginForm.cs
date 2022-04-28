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
    public partial class LoginForm : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public LoginForm()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from SpotifyUser where Username =: username and userPassword =: password";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("username", userName_txtBox.Text);
            cmd.Parameters.Add("password", Password_txtBox.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            if(dr.Read() &&
                userName_txtBox.Text == dr[3].ToString() && Password_txtBox.Text == dr[4].ToString())
            {
                  MessageBox.Show("Login Successfully");
                HomeForm homeForm = new HomeForm();
                this.Hide();
                homeForm.ShowDialog();
                this.Close();
            }
            
            else
                MessageBox.Show("Username or password is invalid");
           
            dr.Close();
     
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
