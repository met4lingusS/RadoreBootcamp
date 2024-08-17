
namespace OdemeFormu
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
            cmbOdemeTipi = new ComboBox();
            label2 = new Label();
            txtTutar = new TextBox();
            btnOdemeYap = new Button();
            lblSonuc = new Label();
            btnYeniOdeme = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 33);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Ödeme Tipi";
            label1.Click += label1_Click;
            // 
            // cmbOdemeTipi
            // 
            cmbOdemeTipi.FormattingEnabled = true;
            cmbOdemeTipi.Items.AddRange(new object[] { "Seçiniz", "KrediKarti", "MailOrder", "ApplePay", "GooglePay" });
            cmbOdemeTipi.Location = new Point(211, 27);
            cmbOdemeTipi.Margin = new Padding(3, 2, 3, 2);
            cmbOdemeTipi.Name = "cmbOdemeTipi";
            cmbOdemeTipi.Size = new Size(167, 23);
            cmbOdemeTipi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 95);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Tutar:";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(211, 93);
            txtTutar.Margin = new Padding(3, 2, 3, 2);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(105, 23);
            txtTutar.TabIndex = 3;
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.Location = new Point(211, 154);
            btnOdemeYap.Margin = new Padding(3, 2, 3, 2);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(105, 22);
            btnOdemeYap.TabIndex = 4;
            btnOdemeYap.Text = "ÖDEME YAP";
            btnOdemeYap.UseVisualStyleBackColor = true;
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(45, 250);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(43, 15);
            lblSonuc.TabIndex = 5;
            lblSonuc.Text = "Sonuç:";
            // 
            // btnYeniOdeme
            // 
            btnYeniOdeme.Location = new Point(369, 208);
            btnYeniOdeme.Name = "btnYeniOdeme";
            btnYeniOdeme.Size = new Size(72, 57);
            btnYeniOdeme.TabIndex = 6;
            btnYeniOdeme.Text = "Yeni Bir Ödeme Yap";
            btnYeniOdeme.UseVisualStyleBackColor = true;
            btnYeniOdeme.Click += btnYeniOdeme_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 297);
            Controls.Add(btnYeniOdeme);
            Controls.Add(lblSonuc);
            Controls.Add(btnOdemeYap);
            Controls.Add(txtTutar);
            Controls.Add(label2);
            Controls.Add(cmbOdemeTipi);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbOdemeTipi;
        private Label label2;
        private TextBox txtTutar;
        private Button btnOdemeYap;
        private Label lblSonuc;
        private Button btnYeniOdeme;
    }
}
