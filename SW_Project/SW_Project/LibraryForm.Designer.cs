
namespace SW_Project
{
    partial class LibraryForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.songslist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(33, 381);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(125, 29);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // songslist
            // 
            this.songslist.FormattingEnabled = true;
            this.songslist.ItemHeight = 16;
            this.songslist.Location = new System.Drawing.Point(55, 26);
            this.songslist.Name = "songslist";
            this.songslist.Size = new System.Drawing.Size(709, 340);
            this.songslist.TabIndex = 1;
            this.songslist.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.songslist);
            this.Controls.Add(this.BackButton);
            this.Name = "LibraryForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListBox songslist;
    }
}