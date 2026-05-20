using Npgsql;
using System;
using System.Windows.Forms;

namespace cweed
{
    public partial class FormMasuk : Form
    {
        public FormMasuk()
        {
            InitializeComponent();
        }

        // ==========================================
        // TOMBOL KEMBALI
        // ==========================================
        private void kembali_masuk_Click(object sender, EventArgs e)
        {
            Welcome w = new Welcome();
            w.Show();
            this.Hide();
        }

        // ==========================================
        // TOMBOL MASUK / LOGIN
        // ==========================================
        private void masuk_masuk_Click(object sender, EventArgs e)
        {
            // Validasi: Cek apakah inputan masih kosong
            if (string.IsNullOrWhiteSpace(username_masuk.Text) || string.IsNullOrWhiteSpace(sandi_masuk.Text))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NpgsqlConnection conn = Connection.GetConnection();

            try
            {
                conn.Open();

                string query = @"
                SELECT * FROM nelayan
                WHERE username = @username
                AND sandi = @sandi";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username_masuk.Text);
                cmd.Parameters.AddWithValue("@sandi", sandi_masuk.Text);

                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // HAPUS kode yang lama, ganti dengan baris di bawah ini:
                    // Kita mengambil data langsung dari kolom database PostgreSQL bernama "nama_nelayan"
                    UserSession.id_nelayan_masuk = Convert.ToInt32(rd["id_nelayan"]);
                    UserSession.nama_nelayan_masuk = rd["nama_nelayan"].ToString();

                    // 2. Panggil Form DashBoard
                    DashBoard ds = new DashBoard();
                    ds.Show();

                    // 3. Sembunyikan form login
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Username atau sandi salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void username_masuk_Click(object sender, EventArgs e)
        {

        }

        private void username_masuk_Enter(object sender, EventArgs e)
        {

        }

        private void username_masuk_Leave(object sender, EventArgs e)
        {

        }

        private void sandi_masuk_Click(object sender, EventArgs e)
        {

        }

        private void sandi_masuk_Enter(object sender, EventArgs e)
        {

        }

        private void sandi_masuk_Leave(object sender, EventArgs e)
        {

        }
    }
}