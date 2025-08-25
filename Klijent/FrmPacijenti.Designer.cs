namespace Klijent
{
    partial class FrmPacijenti
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
            txtKriterijum = new TextBox();
            btnPretrazi = new Button();
            dgvPacijenti = new DataGridView();
            btnPrikazi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPacijenti).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 61);
            label1.Name = "label1";
            label1.Size = new Size(355, 21);
            label1.TabIndex = 0;
            label1.Text = "Unesite ime i prezime pacijenta za pretragu:";
            // 
            // txtKriterijum
            // 
            txtKriterijum.Location = new Point(425, 61);
            txtKriterijum.Name = "txtKriterijum";
            txtKriterijum.Size = new Size(400, 23);
            txtKriterijum.TabIndex = 1;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Cursor = Cursors.Hand;
            btnPretrazi.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPretrazi.Location = new Point(864, 61);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(138, 55);
            btnPretrazi.TabIndex = 2;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // dgvPacijenti
            // 
            dgvPacijenti.AllowUserToAddRows = false;
            dgvPacijenti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacijenti.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPacijenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacijenti.Location = new Point(64, 147);
            dgvPacijenti.Name = "dgvPacijenti";
            dgvPacijenti.Size = new Size(938, 214);
            dgvPacijenti.TabIndex = 3;
            // 
            // btnPrikazi
            // 
            btnPrikazi.Cursor = Cursors.Hand;
            btnPrikazi.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrikazi.Location = new Point(425, 384);
            btnPrikazi.Name = "btnPrikazi";
            btnPrikazi.Size = new Size(219, 55);
            btnPrikazi.TabIndex = 4;
            btnPrikazi.Text = "Prikaži";
            btnPrikazi.UseVisualStyleBackColor = true;
            btnPrikazi.Click += btnPrikazi_Click;
            // 
            // FrmPacijenti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 473);
            Controls.Add(btnPrikazi);
            Controls.Add(dgvPacijenti);
            Controls.Add(btnPretrazi);
            Controls.Add(txtKriterijum);
            Controls.Add(label1);
            Name = "FrmPacijenti";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pacijenti";
            ((System.ComponentModel.ISupportInitialize)dgvPacijenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox txtKriterijum;
        private Button btnPretrazi;
        public DataGridView dgvPacijenti;
        private Button btnPrikazi;
    }
}