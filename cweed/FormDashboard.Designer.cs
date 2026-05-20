namespace cweed
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            LBnama_dashboard = new Label();
            wlc = new Label();
            panel1 = new Panel();
            keluar_dashboard = new Button();
            InputStok_dashboard = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LBnama_dashboard
            // 
            LBnama_dashboard.AutoSize = true;
            LBnama_dashboard.BackColor = Color.Transparent;
            LBnama_dashboard.BorderStyle = BorderStyle.FixedSingle;
            LBnama_dashboard.Cursor = Cursors.AppStarting;
            LBnama_dashboard.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBnama_dashboard.ForeColor = Color.Red;
            LBnama_dashboard.Location = new Point(377, 108);
            LBnama_dashboard.Name = "LBnama_dashboard";
            LBnama_dashboard.Size = new Size(2, 59);
            LBnama_dashboard.TabIndex = 0;
            // 
            // wlc
            // 
            wlc.AutoSize = true;
            wlc.BackColor = Color.Transparent;
            wlc.FlatStyle = FlatStyle.Flat;
            wlc.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wlc.ForeColor = SystemColors.HotTrack;
            wlc.Location = new Point(379, 147);
            wlc.Name = "wlc";
            wlc.Size = new Size(0, 57);
            wlc.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(keluar_dashboard);
            panel1.Controls.Add(InputStok_dashboard);
            panel1.Location = new Point(413, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 169);
            panel1.TabIndex = 5;
            // 
            // keluar_dashboard
            // 
            keluar_dashboard.BackColor = Color.Red;
            keluar_dashboard.Font = new Font("Segoe UI", 10F);
            keluar_dashboard.ForeColor = SystemColors.ButtonHighlight;
            keluar_dashboard.Location = new Point(178, 95);
            keluar_dashboard.Name = "keluar_dashboard";
            keluar_dashboard.Size = new Size(173, 53);
            keluar_dashboard.TabIndex = 2;
            keluar_dashboard.Text = "KELUAR";
            keluar_dashboard.UseVisualStyleBackColor = false;
            keluar_dashboard.Click += keluar_dashboard_Click;
            // 
            // InputStok_dashboard
            // 
            InputStok_dashboard.BackColor = SystemColors.ActiveCaption;
            InputStok_dashboard.Font = new Font("Segoe UI", 12F);
            InputStok_dashboard.ForeColor = Color.Firebrick;
            InputStok_dashboard.Location = new Point(40, 22);
            InputStok_dashboard.Name = "InputStok_dashboard";
            InputStok_dashboard.Size = new Size(460, 53);
            InputStok_dashboard.TabIndex = 0;
            InputStok_dashboard.Text = "Input Stok";
            InputStok_dashboard.UseVisualStyleBackColor = false;
            InputStok_dashboard.Click += InputStok_dashboard_Click;
            InputStok_dashboard.Enter += InputStok_dashboard_Enter;
            InputStok_dashboard.Leave += InputStok_dashboard_Leave;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1197, 580);
            Controls.Add(panel1);
            Controls.Add(wlc);
            Controls.Add(LBnama_dashboard);
            Name = "DashBoard";
            Text = "FormDashboard";
            Load += DashBoard_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBnama_dashboard;
        private Label wlc;
        private Panel panel1;
        private Button keluar_dashboard;
        private Button InputStok_dashboard;
    }
}