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
    public partial class FormLogin : Form, IUserView
    {
        private UserPresenter _presenter;
        public FormLogin()
        {
            InitializeComponent();
            _presenter = new UserPresenter(this);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }
        public void ShowLoginResult(bool success)
        {
            if (success)
            {
                MessageBox.Show("Login berhasil!");
            }
            else
            {
                MessageBox.Show("Email atau password salah.");
            }
        }
        public void ShowRegisterResult(bool success)
        {
            if (success)
            {
                MessageBox.Show("Registrasi berhasil!");
            }
            else
            {
                MessageBox.Show("Registrasi gagal, coba lagi.");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            _presenter.Login(TBUsername.Text, TBPassword.Text);

        }
    }
}
