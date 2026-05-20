using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cweed
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        // Fungsi ini akan berjalan otomatis saat halaman Dashboard pertama kali terbuka
        private void DashBoard_Load(object sender, EventArgs e)
        {
            // Mengambil username dari UserSession tanpa perlu query ke database lagi
            LBnama_dashboard.Text = "Selamat Datang, " + UserSession.nama_nelayan_masuk;
        }

        // ==========================================
        // TOMBOL INPUT STOK DIKLIK
        // ==========================================
        private void InputStok_dashboard_Click(object sender, EventArgs e)
        {
            // Panggil FormInputStok yang baru kamu buat
            FormInputCweed formInput = new FormInputCweed();

            // Tampilkan sebagai pop-up (dialog) di atas Dashboard
            formInput.ShowDialog();
        }

        private void InputStok_dashboard_Enter(object sender, EventArgs e)
        {

        }

        private void InputStok_dashboard_Leave(object sender, EventArgs e)
        {

        }

        // ==========================================
        // TOMBOL KELUAR DIKLIK
        // ==========================================
        // ==========================================
        // TOMBOL KELUAR / LOGOUT
        // ==========================================
        private void keluar_dashboard_Click(object sender, EventArgs e)
        {
            // 1. Tampilkan konfirmasi biar user tidak tidak sengaja terklik keluar
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?",
                                                  "Konfirmasi Keluar",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 2. BERSIHKAN DATA SESSION (Keamanan data agar tidak tersisa di memori)
                UserSession.id_nelayan_masuk = 0;
                UserSession.nama_nelayan_masuk = null;
                UserSession.username_masuk = null;

                // 3. Panggil dan munculkan kembali Form Welcome
                Welcome w = new Welcome();
                w.Show();

                // 4. Tutup halaman Dashboard ini sepenuhnya
                this.Close();
            }
        }
    }
}