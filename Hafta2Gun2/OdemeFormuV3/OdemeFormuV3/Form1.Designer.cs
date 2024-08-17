namespace OdemeFormuV3
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            lblSonuc = new Label();
            cmbOdemeTipi = new ComboBox();
            txtTutar = new TextBox();
            btnOdemeYap = new Button();
            btnYeniOdeme = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(54, 60);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 0;
            label1.Text = "Ödeme Tipi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(54, 130);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 1;
            label2.Text = "Tutar:";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 12F);
            lblSonuc.Location = new Point(54, 207);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(70, 28);
            lblSonuc.TabIndex = 2;
            lblSonuc.Text = "Sonuç:";
            // 
            // cmbOdemeTipi
            // 
            cmbOdemeTipi.FormattingEnabled = true;
            cmbOdemeTipi.Location = new Point(177, 60);
            cmbOdemeTipi.Name = "cmbOdemeTipi";
            cmbOdemeTipi.Size = new Size(260, 28);
            cmbOdemeTipi.TabIndex = 3;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(177, 130);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(125, 27);
            txtTutar.TabIndex = 4;
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.Font = new Font("Segoe UI", 12F);
            btnOdemeYap.Location = new Point(54, 308);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(127, 61);
            btnOdemeYap.TabIndex = 5;
            btnOdemeYap.Text = "ÖDEME YAP";
            btnOdemeYap.UseVisualStyleBackColor = true;
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // btnYeniOdeme
            // 
            btnYeniOdeme.Location = new Point(310, 311);
            btnYeniOdeme.Name = "btnYeniOdeme";
            btnYeniOdeme.Size = new Size(127, 61);
            btnYeniOdeme.TabIndex = 6;
            btnYeniOdeme.Text = "YENİ ÖDEME";
            btnYeniOdeme.UseVisualStyleBackColor = true;
            btnYeniOdeme.Click += btnYeniOdeme_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 398);
            Controls.Add(btnYeniOdeme);
            Controls.Add(btnOdemeYap);
            Controls.Add(txtTutar);
            Controls.Add(cmbOdemeTipi);
            Controls.Add(lblSonuc);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblSonuc;
        private ComboBox cmbOdemeTipi;
        private TextBox txtTutar;
        private Button btnOdemeYap;
        private Button btnYeniOdeme;
    }
}
