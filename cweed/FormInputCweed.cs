using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql; // Pastikan ini sudah ditambahkan untuk koneksi PostgreSQL

namespace cweed
{
    public partial class FormInputCweed : Form
    {
        public FormInputCweed()
        {
            InitializeComponent();
        }

        // =======================================================
        // TOMBOL SIMPAN DATA STOK
        // =======================================================
        private void simpan_input_Click(object sender, EventArgs e)
        {
            // 1. Validasi: Jangan sampai kosong atau masih teks placeholder
            if (cbJenis.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtStok.Text) ||
                txtStok.Text == "stok (kg)")
            {
                MessageBox.Show("Semua data stok wajib diisi dengan benar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Ambil koneksi database
            NpgsqlConnection conn = Connection.GetConnection();

            try
            {
                conn.Open();

                // Query membawa id_nelayan dari UserSession sebagai Foreign Key
                string query = @"
                INSERT INTO stok_rumput_laut 
                (id_nelayan, jenis_rumput_laut, stok_kg, tanggal_input) 
                VALUES 
                (@id_nelayan, @jenis, @stok, @tanggal)";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                // Mengisi parameter berdasarkan inputan form dan session pelogin
                cmd.Parameters.AddWithValue("@id_nelayan", UserSession.id_nelayan_masuk);
                cmd.Parameters.AddWithValue("@jenis", cbJenis.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@stok", Convert.ToDecimal(txtStok.Text));
                cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.Date); // Pastikan nama DateTimePicker kamu 'dtpTanggal'

                cmd.ExecuteNonQuery();

                // Notifikasi sukses sesuai request kamu
                MessageBox.Show("stok telah disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Setelah sukses disimpan, baru form ini menutup otomatis kembali ke Dashboard
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // =======================================================
        // TOMBOL BATAL (Batal simpan, teks tetep di situ buat edit typo)
        // =======================================================
        private void batal_input_Click(object sender, EventArgs e)
        {
            // Beri tahu user proses dibatalkan
            MessageBox.Show("Proses simpan dibatalkan. Silakan periksa atau edit kembali data Anda.",
                            "Info",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            // Kursor otomatis standby di kotak stok biar user langsung bisa benerin yang typo
            txtStok.Focus();
        }

        // =======================================================
        // LOGIKA PLACEHOLDER UNTUK TEXTBOX STOK
        // =======================================================
        private void txtStok_Enter(object sender, EventArgs e)
        {
            // Kalau isinya masih tulisan petunjuk, kosongkan saat diklik
            if (txtStok.Text == "stok (kg)")
            {
                txtStok.Text = "";
            }
        }

        private void txtStok_Leave(object sender, EventArgs e)
        {
            // Kalau ditinggal dalam keadaan kosong, munculkan tulisan petunjuk lagi
            if (string.IsNullOrWhiteSpace(txtStok.Text))
            {
                txtStok.Text = "stok (kg)";
            }
        }

        // Sisa method kosong bawaan design (Bisa dibiarkan saja)
        private void cbJenis_Click(object sender, EventArgs e)
        {
        }

        private void txtStok_Click(object sender, EventArgs e)
        {
        }
    }
}