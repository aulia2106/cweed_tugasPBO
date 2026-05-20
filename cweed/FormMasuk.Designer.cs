namespace cweed
{
    partial class FormMasuk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMasuk));
            panel1 = new Panel();
            username_masuk = new TextBox();
            LBsandi_masuk = new Label();
            LBusername_masuk = new Label();
            masuk_masuk = new Button();
            kembali_masuk = new Button();
            masukkan_usn = new Label();
            masuk_header = new Label();
            sandi_masuk = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(sandi_masuk);
            panel1.Controls.Add(username_masuk);
            panel1.Controls.Add(LBsandi_masuk);
            panel1.Controls.Add(LBusername_masuk);
            panel1.Controls.Add(masuk_masuk);
            panel1.Controls.Add(kembali_masuk);
            panel1.Controls.Add(masukkan_usn);
            panel1.Controls.Add(masuk_header);
            panel1.Location = new Point(320, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 356);
            panel1.TabIndex = 3;
            // 
            // username_masuk
            // 
            username_masuk.BackColor = SystemColors.InactiveCaption;
            username_masuk.Font = new Font("Perpetua", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username_masuk.ForeColor = SystemColors.MenuHighlight;
            username_masuk.Location = new Point(89, 132);
            username_masuk.Name = "username_masuk";
            username_masuk.Size = new Size(407, 44);
            username_masuk.TabIndex = 11;
            username_masuk.Click += username_masuk_Click;
            username_masuk.Enter += username_masuk_Enter;
            username_masuk.Leave += username_masuk_Leave;
            // 
            // LBsandi_masuk
            // 
            LBsandi_masuk.AutoSize = true;
            LBsandi_masuk.BackColor = Color.Transparent;
            LBsandi_masuk.FlatStyle = FlatStyle.Flat;
            LBsandi_masuk.Font = new Font("Perpetua", 12F);
            LBsandi_masuk.ForeColor = Color.SteelBlue;
            LBsandi_masuk.Location = new Point(77, 204);
            LBsandi_masuk.Name = "LBsandi_masuk";
            LBsandi_masuk.Size = new Size(102, 28);
            LBsandi_masuk.TabIndex = 10;
            LBsandi_masuk.Text = "Password:";
            // 
            // LBusername_masuk
            // 
            LBusername_masuk.AutoSize = true;
            LBusername_masuk.BackColor = Color.Transparent;
            LBusername_masuk.FlatStyle = FlatStyle.Flat;
            LBusername_masuk.Font = new Font("Perpetua", 12F);
            LBusername_masuk.ForeColor = Color.SteelBlue;
            LBusername_masuk.Location = new Point(77, 101);
            LBusername_masuk.Name = "LBusername_masuk";
            LBusername_masuk.Size = new Size(108, 28);
            LBusername_masuk.TabIndex = 9;
            LBusername_masuk.Text = "Username:";
            // 
            // masuk_masuk
            // 
            masuk_masuk.BackColor = Color.ForestGreen;
            masuk_masuk.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            masuk_masuk.ForeColor = SystemColors.ButtonHighlight;
            masuk_masuk.Location = new Point(473, 306);
            masuk_masuk.Name = "masuk_masuk";
            masuk_masuk.Size = new Size(99, 34);
            masuk_masuk.TabIndex = 8;
            masuk_masuk.Text = "masuk";
            masuk_masuk.UseVisualStyleBackColor = false;
            masuk_masuk.Click += masuk_masuk_Click;
            // 
            // kembali_masuk
            // 
            kembali_masuk.BackColor = Color.Red;
            kembali_masuk.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kembali_masuk.ForeColor = SystemColors.ButtonHighlight;
            kembali_masuk.Location = new Point(368, 306);
            kembali_masuk.Name = "kembali_masuk";
            kembali_masuk.Size = new Size(99, 34);
            kembali_masuk.TabIndex = 7;
            kembali_masuk.Text = "kembali";
            kembali_masuk.UseVisualStyleBackColor = false;
            kembali_masuk.Click += kembali_masuk_Click;
            // 
            // masukkan_usn
            // 
            masukkan_usn.AutoSize = true;
            masukkan_usn.BackColor = Color.Transparent;
            masukkan_usn.FlatStyle = FlatStyle.Flat;
            masukkan_usn.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            masukkan_usn.ForeColor = Color.SteelBlue;
            masukkan_usn.Location = new Point(149, 66);
            masukkan_usn.Name = "masukkan_usn";
            masukkan_usn.Size = new Size(283, 20);
            masukkan_usn.TabIndex = 4;
            masukkan_usn.Text = "masukkan data yang sudah dibuat";
            // 
            // masuk_header
            // 
            masuk_header.AutoSize = true;
            masuk_header.BackColor = Color.Transparent;
            masuk_header.FlatStyle = FlatStyle.Flat;
            masuk_header.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            masuk_header.ForeColor = SystemColors.HotTrack;
            masuk_header.Location = new Point(77, 9);
            masuk_header.Name = "masuk_header";
            masuk_header.Size = new Size(434, 57);
            masuk_header.TabIndex = 3;
            masuk_header.Text = "SILAHKAN MASUK";
            // 
            // sandi_masuk
            // 
            sandi_masuk.BackColor = SystemColors.InactiveCaption;
            sandi_masuk.Font = new Font("Perpetua", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sandi_masuk.ForeColor = SystemColors.MenuHighlight;
            sandi_masuk.Location = new Point(89, 235);
            sandi_masuk.Name = "sandi_masuk";
            sandi_masuk.Size = new Size(407, 44);
            sandi_masuk.TabIndex = 12;
            sandi_masuk.Click += sandi_masuk_Click;
            sandi_masuk.Enter += sandi_masuk_Enter;
            sandi_masuk.Leave += sandi_masuk_Leave;
            // 
            // FormMasuk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1197, 545);
            Controls.Add(panel1);
            Name = "FormMasuk";
            Text = "FormMasuk";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button masuk_masuk;
        private Button kembali_masuk;
        private Label masukkan_usn;
        private Label masuk_header;
        private Label LBusername_masuk;
        private Label LBsandi_masuk;
        private TextBox username_masuk;
        private TextBox sandi_masuk;
    }
}