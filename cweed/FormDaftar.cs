// ============================
// FORMDAFTAR.CS
// ============================

using System;
using System.Windows.Forms;
using Npgsql;

namespace cweed
{
    public partial class FormDaftar : Form
    {
        public FormDaftar()
        {
            InitializeComponent();
        }

        // ============================
        // PLACEHOLDER NAMA
        // ============================
        private void nama_daftar_Enter(object sender, EventArgs e)
        {
            if (nama_daftar.Text == "nama")
            {
                nama_daftar.Text = "";
            }
        }

        // ============================
        // PLACEHOLDER NOMOR HP
        // ============================
        private void nomor_HP_daftar_Enter(object sender, EventArgs e)
        {
            if (nomor_HP_daftar.Text == "nomor hp")
            {
                nomor_HP_daftar.Text = "";
            }
        }

        // ============================
        // PLACEHOLDER USERNAME
        // ============================
        private void username_daftar_Enter(object sender, EventArgs e)
        {
            if (username_daftar.Text == "username")
            {
                username_daftar.Text = "";
            }
        }

        // ============================
        // PLACEHOLDER SANDI
        // ============================
        private void sandi_daftar_Enter(object sender, EventArgs e)
        {
            if (sandi_daftar.Text == "sandi")
            {
                sandi_daftar.Text = "";
            }
        }

        // ============================
        // TOMBOL DAFTAR (FormDaftar.cs)
        // ============================
        private void daftar_daftar_Click(object sender, EventArgs e)
        {
            // Validasi inputan kosong
            if (string.IsNullOrWhiteSpace(username_daftar.Text) || username_daftar.Text == "username" ||
                string.IsNullOrWhiteSpace(sandi_daftar.Text) || sandi_daftar.Text == "sandi")
            {
                MessageBox.Show("Username dan Sandi tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NpgsqlConnection conn = Connection.GetConnection();

            try
            {
                conn.Open();

                // KUNCI UTAMA: Tambahkan 'RETURNING id_nelayan' di akhir query INSERT
                string query = @"
        INSERT INTO nelayan
        (nama_nelayan, nomor_HP, username, sandi)
        VALUES
        (@nama, @hp, @username, @sandi)
        RETURNING id_nelayan"; // <-- Ini agar database langsung mengembalikan ID yang baru dibuat

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nama", nama_daftar.Text);
                cmd.Parameters.AddWithValue("@hp", nomor_HP_daftar.Text);
                cmd.Parameters.AddWithValue("@username", username_daftar.Text);
                cmd.Parameters.AddWithValue("@sandi", sandi_daftar.Text);

                // KUNCI KEDUA: Gunakan ExecuteScalar() untuk mengambil nilai RETURNING tadi
                int idBaru = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show("Register berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // =======================================================
                // MASUKKAN DATA USER BARU KE SESSION GLOBAL
                // =======================================================
                UserSession.id_nelayan_masuk = idBaru;                      // ID hasil tarikan RETURNING tadi
                UserSession.nama_nelayan_masuk = nama_daftar.Text;          // Nama dari TextBox daftar
                UserSession.username_masuk = username_daftar.Text;          // Username dari TextBox daftar
                UserSession.username_daftar = username_daftar.Text;

                // =======================================================
                // LANGSUNG DIALIKHAN KE DASHBOARD
                // =======================================================
                DashBoard ds = new DashBoard();
                ds.Show();
                this.Hide(); // Sembunyikan FormDaftar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // ============================
        // TOMBOL BATAL
        // ============================
        private void batal_daftar_Click(object sender, EventArgs e)
        {
            Welcome w =
            new Welcome();

            w.Show();

            this.Hide();
        }

        private void sandi_daftar_Click(object sender, EventArgs e)
        {

        }

        private void nomor_HP_daftar_Click(object sender, EventArgs e)
        {


        }

        private void nama_daftar_Click(object sender, EventArgs e)
        {

        }

        private void username_daftar_Click(object sender, EventArgs e)
        {

        }

        private void nama_daftar_Leave(object sender, EventArgs e)
        {

        }

        private void nomot_HP_daftar_Leave(object sender, EventArgs e)
        {

        }

        private void username_daftar_Leave(object sender, EventArgs e)
        {

        }

        private void sandi_daftar_Leave(object sender, EventArgs e)
        {

        }

        private void nomor_HP_daftar_Leave(object sender, EventArgs e)
        {

        }
    }
}