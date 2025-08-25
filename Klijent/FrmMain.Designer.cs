namespace Klijent
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            menuStrip1 = new MenuStrip();
            evidencijaPregledaToolStripMenuItem = new ToolStripMenuItem();
            ubaciEvidencijuPregledaToolStripMenuItem = new ToolStripMenuItem();
            evidencijePregledaToolStripMenuItem = new ToolStripMenuItem();
            pacijentToolStripMenuItem = new ToolStripMenuItem();
            ubaciPacijentaToolStripMenuItem = new ToolStripMenuItem();
            pacijentiToolStripMenuItem = new ToolStripMenuItem();
            sertifikatToolStripMenuItem = new ToolStripMenuItem();
            ubaciSertifikatToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { evidencijaPregledaToolStripMenuItem, pacijentToolStripMenuItem, sertifikatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(704, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // evidencijaPregledaToolStripMenuItem
            // 
            evidencijaPregledaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ubaciEvidencijuPregledaToolStripMenuItem, evidencijePregledaToolStripMenuItem });
            evidencijaPregledaToolStripMenuItem.Name = "evidencijaPregledaToolStripMenuItem";
            evidencijaPregledaToolStripMenuItem.Size = new Size(147, 21);
            evidencijaPregledaToolStripMenuItem.Text = "Evidencija pregleda";
            // 
            // ubaciEvidencijuPregledaToolStripMenuItem
            // 
            ubaciEvidencijuPregledaToolStripMenuItem.Name = "ubaciEvidencijuPregledaToolStripMenuItem";
            ubaciEvidencijuPregledaToolStripMenuItem.Size = new Size(244, 22);
            ubaciEvidencijuPregledaToolStripMenuItem.Text = "Ubaci evidenciju pregleda";
            ubaciEvidencijuPregledaToolStripMenuItem.Click += ubaciEvidencijuPregledaToolStripMenuItem_Click;
            // 
            // evidencijePregledaToolStripMenuItem
            // 
            evidencijePregledaToolStripMenuItem.Name = "evidencijePregledaToolStripMenuItem";
            evidencijePregledaToolStripMenuItem.Size = new Size(244, 22);
            evidencijePregledaToolStripMenuItem.Text = "Evidencije pregleda";
            evidencijePregledaToolStripMenuItem.Click += evidencijePregledaToolStripMenuItem_Click;
            // 
            // pacijentToolStripMenuItem
            // 
            pacijentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ubaciPacijentaToolStripMenuItem, pacijentiToolStripMenuItem });
            pacijentToolStripMenuItem.Name = "pacijentToolStripMenuItem";
            pacijentToolStripMenuItem.Size = new Size(73, 21);
            pacijentToolStripMenuItem.Text = "Pacijent";
            // 
            // ubaciPacijentaToolStripMenuItem
            // 
            ubaciPacijentaToolStripMenuItem.Name = "ubaciPacijentaToolStripMenuItem";
            ubaciPacijentaToolStripMenuItem.Size = new Size(177, 22);
            ubaciPacijentaToolStripMenuItem.Text = "Ubaci pacijenta";
            ubaciPacijentaToolStripMenuItem.Click += ubaciPacijentaToolStripMenuItem_Click;
            // 
            // pacijentiToolStripMenuItem
            // 
            pacijentiToolStripMenuItem.Name = "pacijentiToolStripMenuItem";
            pacijentiToolStripMenuItem.Size = new Size(177, 22);
            pacijentiToolStripMenuItem.Text = "Pacijenti";
            pacijentiToolStripMenuItem.Click += pacijentiToolStripMenuItem_Click;
            // 
            // sertifikatToolStripMenuItem
            // 
            sertifikatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ubaciSertifikatToolStripMenuItem });
            sertifikatToolStripMenuItem.Name = "sertifikatToolStripMenuItem";
            sertifikatToolStripMenuItem.Size = new Size(80, 21);
            sertifikatToolStripMenuItem.Text = "Sertifikat";
            // 
            // ubaciSertifikatToolStripMenuItem
            // 
            ubaciSertifikatToolStripMenuItem.Name = "ubaciSertifikatToolStripMenuItem";
            ubaciSertifikatToolStripMenuItem.Size = new Size(175, 22);
            ubaciSertifikatToolStripMenuItem.Text = "Ubaci sertifikat";
            ubaciSertifikatToolStripMenuItem.Click += ubaciSertifikatToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(680, 358);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 397);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Evidencija pregleda";
            FormClosed += FrmMain_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem evidencijaPregledaToolStripMenuItem;
        private ToolStripMenuItem ubaciEvidencijuPregledaToolStripMenuItem;
        private ToolStripMenuItem evidencijePregledaToolStripMenuItem;
        private ToolStripMenuItem pacijentToolStripMenuItem;
        private ToolStripMenuItem ubaciPacijentaToolStripMenuItem;
        private ToolStripMenuItem pacijentiToolStripMenuItem;
        private ToolStripMenuItem sertifikatToolStripMenuItem;
        private ToolStripMenuItem ubaciSertifikatToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}