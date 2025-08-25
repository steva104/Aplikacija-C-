namespace Klijent
{
    partial class FrmPrikaziEvidencijuPregleda
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnObrisiStavku = new Button();
            btnDodajStavku = new Button();
            btnSacuvaj = new Button();
            dgvStavke = new DataGridView();
            groupBox1 = new GroupBox();
            label7 = new Label();
            txtNapomena = new RichTextBox();
            label5 = new Label();
            cmbTretman = new ComboBox();
            label4 = new Label();
            txtUkupnaCena = new TextBox();
            label3 = new Label();
            datePregled = new DateTimePicker();
            label2 = new Label();
            cmbPacijenti = new ComboBox();
            cmbZubari = new ComboBox();
            label1 = new Label();
            label6 = new Label();
            label8 = new Label();
            txtVremePocetka = new TextBox();
            txtVremeZavrsetka = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnObrisiStavku
            // 
            btnObrisiStavku.Cursor = Cursors.Hand;
            btnObrisiStavku.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            btnObrisiStavku.Location = new Point(829, 506);
            btnObrisiStavku.Name = "btnObrisiStavku";
            btnObrisiStavku.Size = new Size(195, 53);
            btnObrisiStavku.TabIndex = 25;
            btnObrisiStavku.Text = "Obriši stavku";
            btnObrisiStavku.UseVisualStyleBackColor = true;
            btnObrisiStavku.Click += btnObrisiStavku_Click;
            // 
            // btnDodajStavku
            // 
            btnDodajStavku.Cursor = Cursors.Hand;
            btnDodajStavku.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            btnDodajStavku.Location = new Point(523, 506);
            btnDodajStavku.Name = "btnDodajStavku";
            btnDodajStavku.Size = new Size(195, 53);
            btnDodajStavku.TabIndex = 24;
            btnDodajStavku.Text = "Dodaj stavku";
            btnDodajStavku.UseVisualStyleBackColor = true;
            btnDodajStavku.Click += btnDodajStavku_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Cursor = Cursors.Hand;
            btnSacuvaj.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            btnSacuvaj.Location = new Point(245, 506);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(195, 53);
            btnSacuvaj.TabIndex = 23;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // dgvStavke
            // 
            dgvStavke.AllowUserToAddRows = false;
            dgvStavke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvStavke.DefaultCellStyle = dataGridViewCellStyle4;
            dgvStavke.Location = new Point(523, 291);
            dgvStavke.Name = "dgvStavke";
            dgvStavke.ReadOnly = true;
            dgvStavke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStavke.Size = new Size(501, 203);
            dgvStavke.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtNapomena);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbTretman);
            groupBox1.Location = new Point(523, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(501, 252);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Stavka evidencije pregleda";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label7.Location = new Point(63, 119);
            label7.Name = "label7";
            label7.Size = new Size(99, 21);
            label7.TabIndex = 12;
            label7.Text = "Napomena:";
            // 
            // txtNapomena
            // 
            txtNapomena.Location = new Point(205, 119);
            txtNapomena.Name = "txtNapomena";
            txtNapomena.Size = new Size(232, 90);
            txtNapomena.TabIndex = 11;
            txtNapomena.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label5.Location = new Point(63, 52);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 9;
            label5.Text = "Tretman:";
            // 
            // cmbTretman
            // 
            cmbTretman.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTretman.FormattingEnabled = true;
            cmbTretman.Location = new Point(205, 52);
            cmbTretman.Name = "cmbTretman";
            cmbTretman.Size = new Size(232, 23);
            cmbTretman.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label4.Location = new Point(84, 337);
            label4.Name = "label4";
            label4.Size = new Size(117, 21);
            label4.TabIndex = 20;
            label4.Text = "Ukupna cena:";
            // 
            // txtUkupnaCena
            // 
            txtUkupnaCena.Enabled = false;
            txtUkupnaCena.Location = new Point(245, 337);
            txtUkupnaCena.Name = "txtUkupnaCena";
            txtUkupnaCena.ReadOnly = true;
            txtUkupnaCena.Size = new Size(195, 23);
            txtUkupnaCena.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label3.Location = new Point(84, 235);
            label3.Name = "label3";
            label3.Size = new Size(139, 21);
            label3.TabIndex = 18;
            label3.Text = "Datum pregleda:";
            // 
            // datePregled
            // 
            datePregled.Location = new Point(245, 235);
            datePregled.Name = "datePregled";
            datePregled.Size = new Size(195, 23);
            datePregled.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(84, 142);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 16;
            label2.Text = "Pacijent:";
            // 
            // cmbPacijenti
            // 
            cmbPacijenti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPacijenti.FormattingEnabled = true;
            cmbPacijenti.Location = new Point(245, 142);
            cmbPacijenti.Name = "cmbPacijenti";
            cmbPacijenti.Size = new Size(195, 23);
            cmbPacijenti.TabIndex = 15;
            // 
            // cmbZubari
            // 
            cmbZubari.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbZubari.FormattingEnabled = true;
            cmbZubari.Location = new Point(245, 52);
            cmbZubari.Name = "cmbZubari";
            cmbZubari.Size = new Size(195, 23);
            cmbZubari.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(84, 52);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 13;
            label1.Text = "Zubar:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label6.Location = new Point(84, 400);
            label6.Name = "label6";
            label6.Size = new Size(130, 21);
            label6.TabIndex = 26;
            label6.Text = "Vreme početka:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label8.Location = new Point(84, 446);
            label8.Name = "label8";
            label8.Size = new Size(143, 21);
            label8.TabIndex = 27;
            label8.Text = "Vreme završetka:";
            // 
            // txtVremePocetka
            // 
            txtVremePocetka.Location = new Point(245, 403);
            txtVremePocetka.Name = "txtVremePocetka";
            txtVremePocetka.Size = new Size(195, 23);
            txtVremePocetka.TabIndex = 28;
            // 
            // txtVremeZavrsetka
            // 
            txtVremeZavrsetka.Location = new Point(245, 447);
            txtVremeZavrsetka.Name = "txtVremeZavrsetka";
            txtVremeZavrsetka.Size = new Size(195, 23);
            txtVremeZavrsetka.TabIndex = 29;
            // 
            // FrmPrikaziEvidencijuPregleda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 607);
            Controls.Add(txtVremeZavrsetka);
            Controls.Add(txtVremePocetka);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(btnObrisiStavku);
            Controls.Add(btnDodajStavku);
            Controls.Add(btnSacuvaj);
            Controls.Add(dgvStavke);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(txtUkupnaCena);
            Controls.Add(label3);
            Controls.Add(datePregled);
            Controls.Add(label2);
            Controls.Add(cmbPacijenti);
            Controls.Add(cmbZubari);
            Controls.Add(label1);
            Name = "FrmPrikaziEvidencijuPregleda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Evidencija pregleda";
            ((System.ComponentModel.ISupportInitialize)dgvStavke).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnObrisiStavku;
        private Button btnDodajStavku;
        private Button btnSacuvaj;
        public DataGridView dgvStavke;
        private GroupBox groupBox1;
        private Label label7;
        public RichTextBox txtNapomena;
        private Label label5;
        public ComboBox cmbTretman;
        private Label label4;
        public TextBox txtUkupnaCena;
        private Label label3;
        public DateTimePicker datePregled;
        private Label label2;
        public ComboBox cmbPacijenti;
        public ComboBox cmbZubari;
        private Label label1;
        private Label label6;
        private Label label8;
        public TextBox txtVremePocetka;
        public TextBox txtVremeZavrsetka;
        private TextBox textBox2;
    }
}