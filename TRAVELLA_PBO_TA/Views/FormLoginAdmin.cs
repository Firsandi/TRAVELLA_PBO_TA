using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRAVELLA_PBO_TA.Interfaces;
using TRAVELLA_PBO_TA.Models;
using TRAVELLA_PBO_TA.Presenters;



namespace TRAVELLA_PBO_TA.Views
{
    public partial class FormLogin : Form, IAdminView
    {
        private AdminPresenter _presenter; // ✅ Gunakan presenter yang benar

        public FormLogin()
        {
            InitializeComponent();
            _presenter = new AdminPresenter(this); // ✅ Sesuaikan presenter dengan form admin
        }

        public void ShowAdminLoginResult(bool success)
        {
            if (success)
            {
                MessageBox.Show("Login Berhasil");

            }
            else
            {
                MessageBox.Show("Email atau password salah.");
            }
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            _presenter.Login(TBUsername.Text, TBPassword.Text);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FormRegistrasiUser formRegistrasi = new FormRegistrasiUser();
            formRegistrasi.Show();
            this.Hide();
        }
    }
}
