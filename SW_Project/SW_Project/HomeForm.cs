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
    public partial class HomeForm : Form
    {
        string constr = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleDataAdapter adapter;
        OracleCommandBuilder commandBuilder;
        DataSet ds;
       
        public HomeForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_Btn_Click(object sender, EventArgs e)
        {
            string cmdstr = "select * from Songs where song_name =:name";
            string cmdstr1 = "select * from Artist where FirstName =:name";

            if(Search_txtBox.Text == "skyfal" || Search_txtBox.Text == "More" ||
                Search_txtBox.Text == "hello")
            {
                adapter = new OracleDataAdapter(cmdstr, constr);
            }
            else if (Search_txtBox.Text == "selena" || Search_txtBox.Text == "Adam" ||
                Search_txtBox.Text == "Adele")
            {
                adapter = new OracleDataAdapter(cmdstr1, constr);
            }
                adapter.SelectCommand.Parameters.Add("name", Search_txtBox.Text);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void LikedSongs_Btn_Click(object sender, EventArgs e)
        {
            string cmdstr = "select * from likedSongs";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Library_Btn_Click(object sender, EventArgs e)
        {
            LibraryForm libraryForm = new LibraryForm();
            this.Hide();
            libraryForm.ShowDialog();
            this.Close();
        }

        private void Playlist_Btn_Click(object sender, EventArgs e)
        {
            string cmdstr = "select * from PLAYLSIT";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void LikedAlbums_Btn_Click(object sender, EventArgs e)
        {
            string cmdstr = "select * from likedalbum";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void LikedPlaylist_Btn_Click(object sender, EventArgs e)
        {
            string cmdstr = "select * from LIKEDPLAYLIST";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog();
        }
    }
}
