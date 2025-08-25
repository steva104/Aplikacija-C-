namespace Klijent
{
    partial class FrmEvidencije
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
            dgvEvidencije = new DataGridView();
            btnPretrazi = new Button();
            btnPrikazi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEvidencije).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 59);
            label1.Name = "label1";
            label1.Size = new Size(335, 21);
            label1.TabIndex = 0;
            label1.Text = "Unesite ime i prezime zubara za pretragu:";
            // 
            // txtKriterijum
            // 
            txtKriterijum.Location = new Point(363, 60);
            txtKriterijum.Name = "txtKriterijum";
            txtKriterijum.Size = new Size(327, 23);
            txtKriterijum.TabIndex = 1;
            // 
            // dgvEvidencije
            // 
            dgvEvidencije.AllowUserToAddRows = false;
            dgvEvidencije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEvidencije.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEvidencije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvidencije.Location = new Point(31, 121);
            dgvEvidencije.Name = "dgvEvidencije";
            dgvEvidencije.Size = new Size(768, 214);
            dgvEvidencije.TabIndex = 4;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Cursor = Cursors.Hand;
            btnPretrazi.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPretrazi.Location = new Point(696, 59);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(103, 52);
            btnPretrazi.TabIndex = 5;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // btnPrikazi
            // 
            btnPrikazi.Cursor = Cursors.Hand;
            btnPrikazi.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrikazi.Location = new Point(276, 367);
            btnPrikazi.Name = "btnPrikazi";
            btnPrikazi.Size = new Size(215, 52);
            btnPrikazi.TabIndex = 6;
            btnPrikazi.Text = "Prikaži";
            btnPrikazi.UseVisualStyleBackColor = true;
            btnPrikazi.Click += btnPrikazi_Click;
            // 
            // FrmEvidencije
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 450);
            Controls.Add(btnPrikazi);
            Controls.Add(btnPretrazi);
            Controls.Add(dgvEvidencije);
            Controls.Add(txtKriterijum);
            Controls.Add(label1);
            Name = "FrmEvidencije";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Evidencije pregleda";
            ((System.ComponentModel.ISupportInitialize)dgvEvidencije).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox txtKriterijum;
        public DataGridView dgvEvidencije;
        private Button btnPretrazi;
        private Button btnPrikazi;
    }
}