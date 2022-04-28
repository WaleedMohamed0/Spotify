namespace SW_Project
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
            this.Playlist_Btn = new System.Windows.Forms.Button();
            this.Library_Btn = new System.Windows.Forms.Button();
            this.Search_Btn = new System.Windows.Forms.Button();
            this.Search_txtBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
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
            // Playlist_Btn
            // 
            this.Playlist_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playlist_Btn.Location = new System.Drawing.Point(25, 494);
            this.Playlist_Btn.Name = "Playlist_Btn";
            this.Playlist_Btn.Size = new System.Drawing.Size(195, 39);
            this.Playlist_Btn.TabIndex = 6;
            this.Playlist_Btn.Text = "Playlist";
            this.Playlist_Btn.UseVisualStyleBackColor = true;
            // 
            // Library_Btn
            // 
            this.Library_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Library_Btn.Location = new System.Drawing.Point(25, 347);
            this.Library_Btn.Name = "Library_Btn";
            this.Library_Btn.Size = new System.Drawing.Size(195, 39);
            this.Library_Btn.TabIndex = 5;
            this.Library_Btn.Text = "Library";
            this.Library_Btn.UseVisualStyleBackColor = true;
            // 
            // Search_Btn
            // 
            this.Search_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Btn.Location = new System.Drawing.Point(77, 111);
            this.Search_Btn.Name = "Search_Btn";
            this.Search_Btn.Size = new System.Drawing.Size(117, 39);
            this.Search_Btn.TabIndex = 4;
            this.Search_Btn.Text = "Search";
            this.Search_Btn.UseVisualStyleBackColor = true;
            // 
            // Search_txtBox
            // 
            this.Search_txtBox.BackColor = System.Drawing.Color.Gray;
            this.Search_txtBox.Location = new System.Drawing.Point(77, 52);
            this.Search_txtBox.Name = "Search_txtBox";
            this.Search_txtBox.Size = new System.Drawing.Size(159, 22);
            this.Search_txtBox.TabIndex = 0;
            this.Search_txtBox.Text = "Search";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(13, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(51, 60);
            this.panel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel2.Location = new System.Drawing.Point(274, 599);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 145);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(274, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1042, 219);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(24, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Singer";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(216)))), ((int)(((byte)(87)))));
            this.button1.Location = new System.Drawing.Point(22, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play Song";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 756);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Playlist_Btn;
        private System.Windows.Forms.Button Library_Btn;
        private System.Windows.Forms.Button Search_Btn;
        private System.Windows.Forms.TextBox Search_txtBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}