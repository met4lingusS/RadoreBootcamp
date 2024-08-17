namespace OdemeFormuV2
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
            btnYeniOdeme = new Button();
            lblSonuc = new Label();
            btnOdemeYap = new Button();
            txtTutar = new TextBox();
            label2 = new Label();
            cmbOdemeTipi = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnYeniOdeme
            // 
            btnYeniOdeme.Location = new Point(534, 189);
            btnYeniOdeme.Name = "btnYeniOdeme";
            btnYeniOdeme.Size = new Size(96, 54);
            btnYeniOdeme.TabIndex = 13;
            btnYeniOdeme.Text = "Yeni Bir Ödeme Yap";
            btnYeniOdeme.UseVisualStyleBackColor = true;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(159, 285);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(52, 20);
            lblSonuc.TabIndex = 12;
            lblSonuc.Text = "Sonuç:";
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.Location = new Point(325, 189);
            btnOdemeYap.Margin = new Padding(3, 2, 3, 2);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(105, 54);
            btnOdemeYap.TabIndex = 11;
            btnOdemeYap.Text = "ÖDEME YAP";
            btnOdemeYap.UseVisualStyleBackColor = true;
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(325, 128);
            txtTutar.Margin = new Padding(3, 2, 3, 2);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(105, 27);
            txtTutar.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 130);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 9;
            label2.Text = "Tutar:";
            // 
            // cmbOdemeTipi
            // 
            cmbOdemeTipi.FormattingEnabled = true;
            cmbOdemeTipi.Items.AddRange(new object[] { "Seçiniz", "KrediKarti", "MailOrder", "ApplePay", "GooglePay" });
            cmbOdemeTipi.Location = new Point(325, 62);
            cmbOdemeTipi.Margin = new Padding(3, 2, 3, 2);
            cmbOdemeTipi.Name = "cmbOdemeTipi";
            cmbOdemeTipi.Size = new Size(223, 28);
            cmbOdemeTipi.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 68);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 7;
            label1.Text = "Ödeme Tipi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnYeniOdeme);
            Controls.Add(lblSonuc);
            Controls.Add(btnOdemeYap);
            Controls.Add(txtTutar);
            Controls.Add(label2);
            Controls.Add(cmbOdemeTipi);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYeniOdeme;
        private Label lblSonuc;
        private Button btnOdemeYap;
        private TextBox txtTutar;
        private Label label2;
        private ComboBox cmbOdemeTipi;
        private Label label1;
    }
}
