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
        OracleConnection conn;
       
        public HomeForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_Btn_Click(object sender, EventArgs e)
        {
            OracleCommand songs = new OracleCommand();
            OracleCommand artists = new OracleCommand();
            OracleCommand albums = new OracleCommand();
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
            songs.Connection = conn;
            albums.Connection = conn;
            artists.Connection = conn;
            songs.CommandType=CommandType.Text;
            songs.CommandText = "Select * from songs where LOWER(song_name) =:search";
            songs.Parameters.Add("search", Search_txtBox.Text.ToLower());
            
            OracleDataReader dr = songs.ExecuteReader();
            if (dr.Read())
            {
                DataTable dt = new DataTable();
                dt.Load(songs.ExecuteReader());
                dataGridView1.DataSource = dt;
            }
            albums.CommandText = "Select * from album where LOWER(album_name) =:search";
            albums.Parameters.Add("search", Search_txtBox.Text.ToLower());
            dr = albums.ExecuteReader();
            if (dr.Read())
            {
                DataTable dt = new DataTable();
                dt.Load(albums.ExecuteReader());
                dataGridView2.DataSource =dt;
            }
            artists.CommandText = "Select * from artist where LOWER(firstname) =:search or LOWER(lastname) =:search";
            artists.Parameters.Add("search", Search_txtBox.Text.ToLower().Split(' ')[0]);
            dr = artists.ExecuteReader();
            if (dr.Read())
            {
                DataTable dt = new DataTable();
                dt.Load(artists.ExecuteReader());
                dataGridView3.DataSource = dt;
            }
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
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }

        private void LikedAlbums_Btn_Click(object sender, EventArgs e)
        {
            string cmdstr = "select * from likedalbum";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

     
        private void HomeForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(constr);
            conn.Open();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog();
        }
    }
}
