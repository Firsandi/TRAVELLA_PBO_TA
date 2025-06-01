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
    public partial class FormHalamanAwal : Form
    {
        public FormHalamanAwal()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormLoginUser formLoginUser = new FormLoginUser();
            formLoginUser.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormLogin formLoginAdmin = new FormLogin();
            formLoginAdmin.Show();
            this.Hide(); // ✅ Sembunyikan halaman awal setelah pindah ke login admin
        }
    }
}

