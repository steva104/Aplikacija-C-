namespace Klijent
{
    partial class FrmKreirajEvidencijuPregleda
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            cmbZubari = new ComboBox();
            cmbPacijenti = new ComboBox();
            label2 = new Label();
            datePregled = new DateTimePicker();
            label3 = new Label();
            txtUkupnaCena = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            txtNapomena = new RichTextBox();
            label5 = new Label();
            cmbTretman = new ComboBox();
            dgvStavke = new DataGridView();
            btnSacuvaj = new Button();
            btnDodajStavku = new Button();
            btnObrisiStavku = new Button();
            label6 = new Label();
            label8 = new Label();
            txtVremePocetka = new TextBox();
            txtVremeZavrsetka = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(45, 59);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 0;
            label1.Text = "Zubar:";
            // 
            // cmbZubari
            // 
            cmbZubari.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbZubari.FormattingEnabled = true;
            cmbZubari.Location = new Point(212, 60);
            cmbZubari.Name = "cmbZubari";
            cmbZubari.Size = new Size(195, 23);
            cmbZubari.TabIndex = 1;
            // 
            // cmbPacijenti
            // 
            cmbPacijenti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPacijenti.FormattingEnabled = true;
            cmbPacijenti.Location = new Point(212, 150);
            cmbPacijenti.Name = "cmbPacijenti";
            cmbPacijenti.Size = new Size(195, 23);
            cmbPacijenti.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(45, 149);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 3;
            label2.Text = "Pacijent:";
            // 
            // datePregled
            // 
            datePregled.Location = new Point(212, 245);
            datePregled.Name = "datePregled";
            datePregled.Size = new Size(195, 23);
            datePregled.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label3.Location = new Point(45, 245);
            label3.Name = "label3";
            label3.Size = new Size(139, 21);
            label3.TabIndex = 5;
            label3.Text = "Datum pregleda:";
            // 
            // txtUkupnaCena
            // 
            txtUkupnaCena.Enabled = false;
            txtUkupnaCena.Location = new Point(212, 348);
            txtUkupnaCena.Name = "txtUkupnaCena";
            txtUkupnaCena.ReadOnly = true;
            txtUkupnaCena.Size = new Size(195, 23);
            txtUkupnaCena.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label4.Location = new Point(45, 347);
            label4.Name = "label4";
            label4.Size = new Size(117, 21);
            label4.TabIndex = 7;
            label4.Text = "Ukupna cena:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtNapomena);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbTretman);
            groupBox1.Location = new Point(473, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(501, 252);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Stavka evidencije pregleda";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            // dgvStavke
            // 
            dgvStavke.AllowUserToAddRows = false;
            dgvStavke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStavke.DefaultCellStyle = dataGridViewCellStyle1;
            dgvStavke.Location = new Point(473, 319);
            dgvStavke.Name = "dgvStavke";
            dgvStavke.ReadOnly = true;
            dgvStavke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStavke.Size = new Size(501, 203);
            dgvStavke.TabIndex = 9;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Cursor = Cursors.Hand;
            btnSacuvaj.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSacuvaj.Location = new Point(212, 543);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(195, 53);
            btnSacuvaj.TabIndex = 10;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnDodajStavku
            // 
            btnDodajStavku.Cursor = Cursors.Hand;
            btnDodajStavku.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            btnDodajStavku.Location = new Point(473, 543);
            btnDodajStavku.Name = "btnDodajStavku";
            btnDodajStavku.Size = new Size(195, 53);
            btnDodajStavku.TabIndex = 11;
            btnDodajStavku.Text = "Dodaj stavku";
            btnDodajStavku.UseVisualStyleBackColor = true;
            btnDodajStavku.Click += btnDodajStavku_Click;
            // 
            // btnObrisiStavku
            // 
            btnObrisiStavku.Cursor = Cursors.Hand;
            btnObrisiStavku.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            btnObrisiStavku.Location = new Point(779, 543);
            btnObrisiStavku.Name = "btnObrisiStavku";
            btnObrisiStavku.Size = new Size(195, 53);
            btnObrisiStavku.TabIndex = 12;
            btnObrisiStavku.Text = "Obriši stavku";
            btnObrisiStavku.UseVisualStyleBackColor = true;
            btnObrisiStavku.Click += btnObrisiStavku_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label6.Location = new Point(45, 414);
            label6.Name = "label6";
            label6.Size = new Size(130, 21);
            label6.TabIndex = 13;
            label6.Text = "Vreme početka:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label8.Location = new Point(45, 460);
            label8.Name = "label8";
            label8.Size = new Size(143, 21);
            label8.TabIndex = 14;
            label8.Text = "Vreme završetka:";
            // 
            // txtVremePocetka
            // 
            txtVremePocetka.Location = new Point(212, 412);
            txtVremePocetka.Name = "txtVremePocetka";
            txtVremePocetka.Size = new Size(195, 23);
            txtVremePocetka.TabIndex = 15;
            // 
            // txtVremeZavrsetka
            // 
            txtVremeZavrsetka.Location = new Point(212, 461);
            txtVremeZavrsetka.Name = "txtVremeZavrsetka";
            txtVremeZavrsetka.Size = new Size(195, 23);
            txtVremeZavrsetka.TabIndex = 16;
            // 
            // FrmKreirajEvidencijuPregleda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 673);
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
            Name = "FrmKreirajEvidencijuPregleda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ubaci evidenciju pregleda";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public ComboBox cmbZubari;
        public ComboBox cmbPacijenti;
        private Label label2;
        public DateTimePicker datePregled;
        private Label label3;
        public TextBox txtUkupnaCena;
        private Label label4;
        private GroupBox groupBox1;
        private Label label7;
        public RichTextBox txtNapomena;
        private Label label5;
        public ComboBox cmbTretman;
        public DataGridView dgvStavke;
        private Button btnSacuvaj;
        private Button btnDodajStavku;
        private Button btnObrisiStavku;
        private Label label6;
        private Label label8;
        public TextBox txtVremePocetka;
        public TextBox txtVremeZavrsetka;
    }
}