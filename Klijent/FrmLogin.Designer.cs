namespace Klijent
{
    partial class FrmLogin
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
            btnPrijava = new Button();
            label1 = new Label();
            label2 = new Label();
            txtKorisnickoIme = new TextBox();
            txtSifra = new TextBox();
            SuspendLayout();
            // 
            // btnPrijava
            // 
            btnPrijava.Cursor = Cursors.Hand;
            btnPrijava.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrijava.Location = new Point(244, 209);
            btnPrijava.Name = "btnPrijava";
            btnPrijava.Size = new Size(169, 56);
            btnPrijava.TabIndex = 0;
            btnPrijava.Text = "Prijavi se";
            btnPrijava.UseVisualStyleBackColor = true;
            btnPrijava.Click += btnPrijava_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(95, 70);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 1;
            label1.Text = "Korisničko ime: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(95, 117);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 2;
            label2.Text = "Šifra: ";
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.Location = new Point(244, 70);
            txtKorisnickoIme.Name = "txtKorisnickoIme";
            txtKorisnickoIme.Size = new Size(169, 23);
            txtKorisnickoIme.TabIndex = 3;
            // 
            // txtSifra
            // 
            txtSifra.Location = new Point(244, 117);
            txtSifra.Name = "txtSifra";
            txtSifra.Size = new Size(169, 23);
            txtSifra.TabIndex = 4;
            txtSifra.UseSystemPasswordChar = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 328);
            Controls.Add(txtSifra);
            Controls.Add(txtKorisnickoIme);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPrijava);
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prijavi se";
            FormClosed += FrmLogin_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrijava;
        private Label label1;
        private Label label2;
        public TextBox txtKorisnickoIme;
        public TextBox txtSifra;
    }
}
