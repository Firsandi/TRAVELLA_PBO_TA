using System.Windows.Forms;

namespace TRAVELLA_PBO_TA.Views
{
    partial class FormLogin
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
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(853, 446);
            this.TBPassword.Multiline = true;
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(417, 40);
            this.TBPassword.TabIndex = 5;
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(853, 333);
            this.TBUsername.Multiline = true;
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(417, 40);
            this.TBUsername.TabIndex = 14;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::TRAVELLA_PBO_TA.Properties.Resources.BG_PANJANG__2_;
            this.pictureBox5.Image = global::TRAVELLA_PBO_TA.Properties.Resources.Tombol_login;
            this.pictureBox5.Location = new System.Drawing.Point(728, 550);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(619, 65);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::TRAVELLA_PBO_TA.Properties.Resources.BG_PANJANG__2_;
            this.pictureBox4.Image = global::TRAVELLA_PBO_TA.Properties.Resources.Form1;
            this.pictureBox4.Location = new System.Drawing.Point(728, 269);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(619, 226);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TRAVELLA_PBO_TA.Properties.Resources.BG_PANJANG__2_;
            this.pictureBox3.Image = global::TRAVELLA_PBO_TA.Properties.Resources.Halo_Admin_;
            this.pictureBox3.Location = new System.Drawing.Point(728, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(619, 61);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TRAVELLA_PBO_TA.Properties.Resources.bg_biru__2_;
            this.pictureBox2.Location = new System.Drawing.Point(728, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(640, 726);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TRAVELLA_PBO_TA.Properties.Resources.BG_pemandangan;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1351, 726);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.ErrorImage = null;
            this.pictureBox6.Image = global::TRAVELLA_PBO_TA.Properties.Resources.logo;
            this.pictureBox6.InitialImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(42, 173);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(584, 227);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private TextBox TBPassword;
        private TextBox TBUsername;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
    }
}