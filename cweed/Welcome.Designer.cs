namespace cweed
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            wlc = new Label();
            masuk_wlc = new Button();
            daftar_wlc = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(wlc);
            panel1.Controls.Add(masuk_wlc);
            panel1.Controls.Add(daftar_wlc);
            panel1.Location = new Point(405, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 233);
            panel1.TabIndex = 1;
            // 
            // wlc
            // 
            wlc.AutoSize = true;
            wlc.BackColor = Color.Transparent;
            wlc.FlatStyle = FlatStyle.Flat;
            wlc.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wlc.ForeColor = SystemColors.HotTrack;
            wlc.Location = new Point(14, 13);
            wlc.Name = "wlc";
            wlc.Size = new Size(408, 57);
            wlc.TabIndex = 3;
            wlc.Text = "WELCOME CWEED";
            wlc.Click += label1_Click_1;
            // 
            // masuk_wlc
            // 
            masuk_wlc.BackColor = SystemColors.ActiveCaption;
            masuk_wlc.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            masuk_wlc.ForeColor = SystemColors.ButtonHighlight;
            masuk_wlc.Location = new Point(89, 136);
            masuk_wlc.Name = "masuk_wlc";
            masuk_wlc.Size = new Size(270, 66);
            masuk_wlc.TabIndex = 2;
            masuk_wlc.Text = "masuk";
            masuk_wlc.UseVisualStyleBackColor = false;
            masuk_wlc.Click += masuk_Click;
            // 
            // daftar_wlc
            // 
            daftar_wlc.BackColor = SystemColors.ActiveCaption;
            daftar_wlc.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            daftar_wlc.ForeColor = SystemColors.ButtonHighlight;
            daftar_wlc.Location = new Point(89, 67);
            daftar_wlc.Name = "daftar_wlc";
            daftar_wlc.Size = new Size(270, 63);
            daftar_wlc.TabIndex = 1;
            daftar_wlc.Text = "daftar";
            daftar_wlc.UseVisualStyleBackColor = false;
            daftar_wlc.Click += daftar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1199, 620);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Welcome";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private Button daftar_wlc;
        private Button masuk_wlc;
        private Label wlc;
    }
}
