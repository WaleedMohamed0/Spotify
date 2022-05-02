﻿namespace SW_Project
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LikedSongs_Btn = new System.Windows.Forms.Button();
            this.LikedAlbums_Btn = new System.Windows.Forms.Button();
            this.Playlist_Btn = new System.Windows.Forms.Button();
            this.Library_Btn = new System.Windows.Forms.Button();
            this.Search_Btn = new System.Windows.Forms.Button();
            this.Search_txtBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LikedPlaylist_Btn = new System.Windows.Forms.Button();
            this.Spotify = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.LikedPlaylist_Btn);
            this.panel1.Controls.Add(this.LikedSongs_Btn);
            this.panel1.Controls.Add(this.LikedAlbums_Btn);
            this.panel1.Controls.Add(this.Playlist_Btn);
            this.panel1.Controls.Add(this.Library_Btn);
            this.panel1.Controls.Add(this.Search_Btn);
            this.panel1.Controls.Add(this.Search_txtBox);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 732);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LikedSongs_Btn
            // 
            this.LikedSongs_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LikedSongs_Btn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LikedSongs_Btn.Location = new System.Drawing.Point(25, 501);
            this.LikedSongs_Btn.Name = "LikedSongs_Btn";
            this.LikedSongs_Btn.Size = new System.Drawing.Size(195, 39);
            this.LikedSongs_Btn.TabIndex = 8;
            this.LikedSongs_Btn.Text = "LikedSongs";
            this.LikedSongs_Btn.UseVisualStyleBackColor = true;
            this.LikedSongs_Btn.Click += new System.EventHandler(this.LikedSongs_Btn_Click);
            // 
            // LikedAlbums_Btn
            // 
            this.LikedAlbums_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LikedAlbums_Btn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LikedAlbums_Btn.Location = new System.Drawing.Point(25, 587);
            this.LikedAlbums_Btn.Name = "LikedAlbums_Btn";
            this.LikedAlbums_Btn.Size = new System.Drawing.Size(195, 39);
            this.LikedAlbums_Btn.TabIndex = 7;
            this.LikedAlbums_Btn.Text = "LikedAlbums";
            this.LikedAlbums_Btn.UseVisualStyleBackColor = true;
            this.LikedAlbums_Btn.Click += new System.EventHandler(this.LikedAlbums_Btn_Click);
            // 
            // Playlist_Btn
            // 
            this.Playlist_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Playlist_Btn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playlist_Btn.Location = new System.Drawing.Point(25, 423);
            this.Playlist_Btn.Name = "Playlist_Btn";
            this.Playlist_Btn.Size = new System.Drawing.Size(195, 39);
            this.Playlist_Btn.TabIndex = 6;
            this.Playlist_Btn.Text = "Playlist";
            this.Playlist_Btn.UseVisualStyleBackColor = true;
            this.Playlist_Btn.Click += new System.EventHandler(this.Playlist_Btn_Click);
            // 
            // Library_Btn
            // 
            this.Library_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Library_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Library_Btn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Library_Btn.Location = new System.Drawing.Point(25, 340);
            this.Library_Btn.Name = "Library_Btn";
            this.Library_Btn.Size = new System.Drawing.Size(195, 39);
            this.Library_Btn.TabIndex = 5;
            this.Library_Btn.Text = "Library";
            this.Library_Btn.UseVisualStyleBackColor = false;
            this.Library_Btn.Click += new System.EventHandler(this.Library_Btn_Click);
            // 
            // Search_Btn
            // 
            this.Search_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_Btn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Btn.Location = new System.Drawing.Point(77, 109);
            this.Search_Btn.Name = "Search_Btn";
            this.Search_Btn.Size = new System.Drawing.Size(117, 39);
            this.Search_Btn.TabIndex = 4;
            this.Search_Btn.Text = "Search";
            this.Search_Btn.UseVisualStyleBackColor = true;
            this.Search_Btn.Click += new System.EventHandler(this.Search_Btn_Click);
            // 
            // Search_txtBox
            // 
            this.Search_txtBox.BackColor = System.Drawing.Color.LightGray;
            this.Search_txtBox.Location = new System.Drawing.Point(77, 52);
            this.Search_txtBox.Name = "Search_txtBox";
            this.Search_txtBox.Size = new System.Drawing.Size(159, 22);
            this.Search_txtBox.TabIndex = 0;
            this.Search_txtBox.Text = "Songs, Artists";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(13, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(48, 62);
            this.panel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel2.Location = new System.Drawing.Point(274, 599);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 145);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(404, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(733, 147);
            this.dataGridView1.TabIndex = 2;
            // 
            // LikedPlaylist_Btn
            // 
            this.LikedPlaylist_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LikedPlaylist_Btn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LikedPlaylist_Btn.Location = new System.Drawing.Point(25, 669);
            this.LikedPlaylist_Btn.Name = "LikedPlaylist_Btn";
            this.LikedPlaylist_Btn.Size = new System.Drawing.Size(195, 39);
            this.LikedPlaylist_Btn.TabIndex = 9;
            this.LikedPlaylist_Btn.Text = "LikedPlaylist";
            this.LikedPlaylist_Btn.UseVisualStyleBackColor = true;
            this.LikedPlaylist_Btn.Click += new System.EventHandler(this.LikedPlaylist_Btn_Click);
            // 
            // Spotify
            // 
            this.Spotify.AutoSize = true;
            this.Spotify.BackColor = System.Drawing.Color.Transparent;
            this.Spotify.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spotify.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Spotify.Location = new System.Drawing.Point(617, 12);
            this.Spotify.Name = "Spotify";
            this.Spotify.Size = new System.Drawing.Size(283, 90);
            this.Spotify.TabIndex = 3;
            this.Spotify.Text = "Spotify";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1203, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1328, 756);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Spotify);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Playlist_Btn;
        private System.Windows.Forms.Button Library_Btn;
        private System.Windows.Forms.Button Search_Btn;
        private System.Windows.Forms.TextBox Search_txtBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LikedSongs_Btn;
        private System.Windows.Forms.Button LikedAlbums_Btn;
        private System.Windows.Forms.Button LikedPlaylist_Btn;
        private System.Windows.Forms.Label Spotify;
        private System.Windows.Forms.Button button1;
    }
}