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
    public partial class mainMenuForm : Form
    {

        Albums albums;
        public mainMenuForm()
        {
            InitializeComponent();
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void Register_Btn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void albums_btn_Click(object sender, EventArgs e)
        {
            AlbumForm albumForm = new AlbumForm();
            albumForm.ShowDialog();
        }

        private void mainMenuForm_Load(object sender, EventArgs e)
        {
        
        }
    }
}
