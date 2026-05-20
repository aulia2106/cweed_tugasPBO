namespace cweed
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        // tombol masuk
        private void masuk_Click(object sender, EventArgs e)
        {
            FormMasuk login = new FormMasuk();

            login.Show();

            this.Hide();
        }

        // tombol daftar
        private void daftar_Click(object sender, EventArgs e)
        {
            FormDaftar regis = new FormDaftar();

            regis.Show();

            this.Hide();
        }
    }
}