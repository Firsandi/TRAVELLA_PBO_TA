using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TRAVELLA_PBO_TA.Interfaces;
using TRAVELLA_PBO_TA.Models;
using TRAVELLA_PBO_TA.Presenters;

namespace TRAVELLA_PBO_TA.Views
{
    public partial class FormRegistrasiUser : Form, IUserView
    {
        private UserPresenter _presenter;
        public FormRegistrasiUser()
        {
            InitializeComponent();
            _presenter = new UserPresenter(this);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // ✅ Validasi input sebelum mengirim data
            if (string.IsNullOrWhiteSpace(TBNama.Text) ||
                string.IsNullOrWhiteSpace(TBEmail.Text) ||
                string.IsNullOrWhiteSpace(TBNomor.Text) ||
                string.IsNullOrWhiteSpace(TBUsername.Text) ||
                string.IsNullOrWhiteSpace(TBPassword.Text))
            {
                MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _presenter.Register(TBNama.Text, TBEmail.Text, TBNomor.Text, TBUsername.Text, TBPassword.Text);
        }
        public void ShowLoginResult(bool success)
        {
        }
        public void ShowRegisterResult(bool success)
        {
            if (success)
            {
                MessageBox.Show("Registrasi berhasil!");
                this.Close(); // ✅ Tutup FormRegistrasi setelah berhasil
            }
            else
            {
                MessageBox.Show("Registrasi gagal, coba lagi.");
            }
        }

        private void TBNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBNomor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
