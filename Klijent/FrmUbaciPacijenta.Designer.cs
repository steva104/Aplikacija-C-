namespace Klijent
{
    partial class FrmUbaciPacijenta
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            txtEmail = new TextBox();
            cmbMesto = new ComboBox();
            btnSacuvaj = new Button();
            label5 = new Label();
            txtBrojTelefona = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(61, 89);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 0;
            label1.Text = "Ime pacijenta: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(61, 158);
            label2.Name = "label2";
            label2.Size = new Size(160, 21);
            label2.TabIndex = 1;
            label2.Text = "Prezime pacijenta: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label3.Location = new Point(61, 223);
            label3.Name = "label3";
            label3.Size = new Size(141, 21);
            label3.TabIndex = 2;
            label3.Text = "Email pacijenta: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label4.Location = new Point(61, 351);
            label4.Name = "label4";
            label4.Size = new Size(242, 21);
            label4.TabIndex = 3;
            label4.Text = "Mesto prebivališta pacijenta: ";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(309, 90);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(246, 23);
            txtIme.TabIndex = 4;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(309, 159);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(246, 23);
            txtPrezime.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(309, 224);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(246, 23);
            txtEmail.TabIndex = 6;
            // 
            // cmbMesto
            // 
            cmbMesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMesto.FormattingEnabled = true;
            cmbMesto.Location = new Point(309, 352);
            cmbMesto.Name = "cmbMesto";
            cmbMesto.Size = new Size(246, 23);
            cmbMesto.TabIndex = 7;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Cursor = Cursors.Hand;
            btnSacuvaj.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSacuvaj.Location = new Point(309, 440);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(246, 38);
            btnSacuvaj.TabIndex = 8;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label5.Location = new Point(61, 284);
            label5.Name = "label5";
            label5.Size = new Size(119, 21);
            label5.TabIndex = 9;
            label5.Text = "Broj telefona: ";
            // 
            // txtBrojTelefona
            // 
            txtBrojTelefona.Location = new Point(309, 282);
            txtBrojTelefona.Name = "txtBrojTelefona";
            txtBrojTelefona.Size = new Size(246, 23);
            txtBrojTelefona.TabIndex = 10;
            // 
            // FrmUbaciPacijenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 530);
            Controls.Add(txtBrojTelefona);
            Controls.Add(label5);
            Controls.Add(btnSacuvaj);
            Controls.Add(cmbMesto);
            Controls.Add(txtEmail);
            Controls.Add(txtPrezime);
            Controls.Add(txtIme);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmUbaciPacijenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ubaci pacijenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public TextBox txtIme;
        public TextBox txtPrezime;
        public TextBox txtEmail;
        public ComboBox cmbMesto;
        private Button btnSacuvaj;
        private Label label5;
        public TextBox txtBrojTelefona;
    }
}