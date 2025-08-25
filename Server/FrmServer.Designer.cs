namespace Server
{
    partial class FrmServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServer));
            btnPokreni = new Button();
            btnZaustavi = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnPokreni
            // 
            btnPokreni.Cursor = Cursors.Hand;
            btnPokreni.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            btnPokreni.Location = new Point(44, 82);
            btnPokreni.Name = "btnPokreni";
            btnPokreni.Size = new Size(151, 92);
            btnPokreni.TabIndex = 0;
            btnPokreni.Text = "Start";
            btnPokreni.UseVisualStyleBackColor = true;
            btnPokreni.Click += btnPokreni_Click;
            // 
            // btnZaustavi
            // 
            btnZaustavi.Cursor = Cursors.Hand;
            btnZaustavi.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            btnZaustavi.Location = new Point(289, 82);
            btnZaustavi.Name = "btnZaustavi";
            btnZaustavi.Size = new Size(151, 92);
            btnZaustavi.TabIndex = 1;
            btnZaustavi.Text = "Stop";
            btnZaustavi.UseVisualStyleBackColor = true;
            btnZaustavi.Click += btnZaustavi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 218);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 2;
            label1.Text = "Server je iskljucen";
            // 
            // FrmServer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 304);
            Controls.Add(label1);
            Controls.Add(btnZaustavi);
            Controls.Add(btnPokreni);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmServer";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPokreni;
        private Button btnZaustavi;
        private Label label1;
    }
}
