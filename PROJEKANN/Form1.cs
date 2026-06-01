using System;
using System.Windows.Forms;
using PROJEKANN.Usercontrol;

namespace PROJEKANN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            login halamanLogin = new login(this);
            this.ClientSize = halamanLogin.Size;
            TampilkanHalaman(halamanLogin);
        }

        public void TampilkanHalaman(UserControl halamanBaru)
        {
            panel1.Controls.Clear();          
            halamanBaru.Dock = DockStyle.None; 
            panel1.Controls.Add(halamanBaru); 
        }
    }
}