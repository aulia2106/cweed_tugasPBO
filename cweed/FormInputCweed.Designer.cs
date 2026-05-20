namespace cweed
{
    partial class FormInputCweed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInputCweed));
            lbJenisInput = new Label();
            cbJenis = new ComboBox();
            lbjumlah = new Label();
            txtStok = new TextBox();
            lbTanggalInput = new Label();
            dtpTanggal = new DateTimePicker();
            simpan_input = new Button();
            batal_input = new Button();
            SuspendLayout();
            // 
            // lbJenisInput
            // 
            lbJenisInput.AutoSize = true;
            lbJenisInput.BackColor = Color.Transparent;
            lbJenisInput.FlatStyle = FlatStyle.Flat;
            lbJenisInput.Font = new Font("Stencil", 8F);
            lbJenisInput.ForeColor = Color.Firebrick;
            lbJenisInput.Location = new Point(463, 103);
            lbJenisInput.Name = "lbJenisInput";
            lbJenisInput.Size = new Size(219, 19);
            lbJenisInput.TabIndex = 5;
            lbJenisInput.Text = "Pilih Jenis Rumput Laut:";
            // 
            // cbJenis
            // 
            cbJenis.BackColor = SystemColors.InactiveCaption;
            cbJenis.Font = new Font("Segoe UI", 12F);
            cbJenis.ForeColor = SystemColors.MenuHighlight;
            cbJenis.FormattingEnabled = true;
            cbJenis.Items.AddRange(new object[] { "Nori", "Eucheuma", "Rumput Laut", "Dulse", "Wakame" });
            cbJenis.Location = new Point(463, 125);
            cbJenis.Name = "cbJenis";
            cbJenis.Size = new Size(343, 40);
            cbJenis.TabIndex = 6;
            cbJenis.Click += cbJenis_Click;
            // 
            // lbjumlah
            // 
            lbjumlah.AutoSize = true;
            lbjumlah.BackColor = Color.Transparent;
            lbjumlah.FlatStyle = FlatStyle.Flat;
            lbjumlah.Font = new Font("Stencil", 8F);
            lbjumlah.ForeColor = Color.Firebrick;
            lbjumlah.Location = new Point(463, 183);
            lbjumlah.Name = "lbjumlah";
            lbjumlah.Size = new Size(232, 19);
            lbjumlah.TabIndex = 7;
            lbjumlah.Text = "Jumlah Rumput Laut (Kg):";
            // 
            // txtStok
            // 
            txtStok.BackColor = SystemColors.InactiveCaption;
            txtStok.Font = new Font("Perpetua", 13F);
            txtStok.ForeColor = SystemColors.MenuHighlight;
            txtStok.Location = new Point(463, 205);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(343, 37);
            txtStok.TabIndex = 17;
            txtStok.Click += txtStok_Click;
            txtStok.Enter += txtStok_Enter;
            txtStok.Leave += txtStok_Leave;
            // 
            // lbTanggalInput
            // 
            lbTanggalInput.AutoSize = true;
            lbTanggalInput.BackColor = Color.Transparent;
            lbTanggalInput.FlatStyle = FlatStyle.Flat;
            lbTanggalInput.Font = new Font("Stencil", 8F);
            lbTanggalInput.ForeColor = Color.Firebrick;
            lbTanggalInput.Location = new Point(463, 260);
            lbTanggalInput.Name = "lbTanggalInput";
            lbTanggalInput.Size = new Size(136, 19);
            lbTanggalInput.TabIndex = 18;
            lbTanggalInput.Text = "Tanggal Input:";
            // 
            // dtpTanggal
            // 
            dtpTanggal.CalendarFont = new Font("Segoe UI", 14F);
            dtpTanggal.CalendarForeColor = SystemColors.MenuHighlight;
            dtpTanggal.CalendarMonthBackground = SystemColors.ActiveCaption;
            dtpTanggal.CalendarTitleBackColor = SystemColors.ButtonHighlight;
            dtpTanggal.CalendarTitleForeColor = SystemColors.MenuHighlight;
            dtpTanggal.CalendarTrailingForeColor = SystemColors.ScrollBar;
            dtpTanggal.Location = new Point(463, 282);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(343, 31);
            dtpTanggal.TabIndex = 19;
            // 
            // simpan_input
            // 
            simpan_input.BackColor = Color.ForestGreen;
            simpan_input.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            simpan_input.ForeColor = SystemColors.ButtonHighlight;
            simpan_input.Location = new Point(707, 362);
            simpan_input.Name = "simpan_input";
            simpan_input.Size = new Size(99, 34);
            simpan_input.TabIndex = 20;
            simpan_input.Text = "simpan";
            simpan_input.UseVisualStyleBackColor = false;
            simpan_input.Click += simpan_input_Click;
            // 
            // batal_input
            // 
            batal_input.BackColor = Color.Red;
            batal_input.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            batal_input.ForeColor = SystemColors.ButtonHighlight;
            batal_input.Location = new Point(596, 362);
            batal_input.Name = "batal_input";
            batal_input.Size = new Size(99, 34);
            batal_input.TabIndex = 21;
            batal_input.Text = "batal";
            batal_input.UseVisualStyleBackColor = false;
            batal_input.Click += batal_input_Click;
            // 
            // FormInputCweed
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1214, 622);
            Controls.Add(batal_input);
            Controls.Add(simpan_input);
            Controls.Add(dtpTanggal);
            Controls.Add(lbTanggalInput);
            Controls.Add(txtStok);
            Controls.Add(lbjumlah);
            Controls.Add(cbJenis);
            Controls.Add(lbJenisInput);
            Name = "FormInputCweed";
            Text = "FormInputCweed";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbJenisInput;
        private ComboBox cbJenis;
        private Label lbjumlah;
        private TextBox txtStok;
        private Label lbTanggalInput;
        private DateTimePicker dtpTanggal;
        private Button simpan_input;
        private Button batal_input;
    }
}