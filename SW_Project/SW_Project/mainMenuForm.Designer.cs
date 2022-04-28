namespace SW_Project
{
    partial class mainMenuForm
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
            this.Login_Btn = new System.Windows.Forms.Button();
            this.Register_Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_Btn
            // 
            this.Login_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Login_Btn.Location = new System.Drawing.Point(52, 172);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(280, 101);
            this.Login_Btn.TabIndex = 0;
            this.Login_Btn.Text = "Login";
            this.Login_Btn.UseVisualStyleBackColor = true;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // Register_Btn
            // 
            this.Register_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Register_Btn.Location = new System.Drawing.Point(448, 172);
            this.Register_Btn.Name = "Register_Btn";
            this.Register_Btn.Size = new System.Drawing.Size(285, 100);
            this.Register_Btn.TabIndex = 1;
            this.Register_Btn.Text = "Register";
            this.Register_Btn.UseVisualStyleBackColor = true;
            this.Register_Btn.Click += new System.EventHandler(this.Register_Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(562, 69);
            this.label3.TabIndex = 7;
            this.label3.Text = "Welcome to Spotify";
            // 
            // mainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Register_Btn);
            this.Controls.Add(this.Login_Btn);
            this.Name = "mainMenuForm";
            this.Text = "mainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_Btn;
        private System.Windows.Forms.Button Register_Btn;
        private System.Windows.Forms.Label label3;
    }
}