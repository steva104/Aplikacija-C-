
namespace Klijent
{
    partial class FrmPrikaziPacijenta
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
            cmbMesto = new ComboBox();
            txtEmail = new TextBox();
            txtPrezime = new TextBox();
            txtIme = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            txtBrojTelefona = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // cmbMesto
            // 
            cmbMesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMesto.FormattingEnabled = true;
            cmbMesto.Location = new Point(321, 342);
            cmbMesto.Name = "cmbMesto";
            cmbMesto.Size = new Size(246, 23);
            cmbMesto.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(321, 200);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(246, 23);
            txtEmail.TabIndex = 14;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(321, 135);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(246, 23);
            txtPrezime.TabIndex = 13;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(321, 66);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(246, 23);
            txtIme.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label4.Location = new Point(49, 342);
            label4.Name = "label4";
            label4.Size = new Size(242, 21);
            label4.TabIndex = 11;
            label4.Text = "Mesto prebivališta pacijenta: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label3.Location = new Point(49, 200);
            label3.Name = "label3";
            label3.Size = new Size(141, 21);
            label3.TabIndex = 10;
            label3.Text = "Email pacijenta: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(49, 134);
            label2.Name = "label2";
            label2.Size = new Size(160, 21);
            label2.TabIndex = 9;
            label2.Text = "Prezime pacijenta: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(49, 65);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 8;
            label1.Text = "Ime pacijenta: ";
            // 
            // btnIzmeni
            // 
            btnIzmeni.Cursor = Cursors.Hand;
            btnIzmeni.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            btnIzmeni.Location = new Point(321, 411);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(111, 56);
            btnIzmeni.TabIndex = 16;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Cursor = Cursors.Hand;
            btnObrisi.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            btnObrisi.Location = new Point(456, 411);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(111, 56);
            btnObrisi.TabIndex = 17;
            btnObrisi.Text = "Obriši";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // txtBrojTelefona
            // 
            txtBrojTelefona.Location = new Point(321, 270);
            txtBrojTelefona.Name = "txtBrojTelefona";
            txtBrojTelefona.Size = new Size(246, 23);
            txtBrojTelefona.TabIndex = 19;
            txtBrojTelefona.TextChanged += this.txtBrojTelefona_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label5.Location = new Point(49, 272);
            label5.Name = "label5";
            label5.Size = new Size(119, 21);
            label5.TabIndex = 18;
            label5.Text = "Broj telefona: ";
            label5.Click += label5_Click;
            // 
            // FrmPrikaziPacijenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 561);
            Controls.Add(txtBrojTelefona);
            Controls.Add(label5);
            Controls.Add(btnObrisi);
            Controls.Add(btnIzmeni);
            Controls.Add(cmbMesto);
            Controls.Add(txtEmail);
            Controls.Add(txtPrezime);
            Controls.Add(txtIme);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPrikaziPacijenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pacijent";
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtBrojTelefona_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        public ComboBox cmbMesto;
        public TextBox txtEmail;
        public TextBox txtPrezime;
        public TextBox txtIme;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnIzmeni;
        private Button btnObrisi;
        public TextBox txtBrojTelefona;
        private Label label5;
    }
}