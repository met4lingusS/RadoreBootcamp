
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 44);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Ödeme Tipi";
            label1.Click += label1_Click;
            // 
            // cmbOdemeTipi
            // 
            cmbOdemeTipi.FormattingEnabled = true;
            cmbOdemeTipi.Items.AddRange(new object[] { "Seçiniz", "KrediKarti", "MailOrder", "ApplePay", "GooglePay" });
            cmbOdemeTipi.Location = new Point(241, 36);
            cmbOdemeTipi.Name = "cmbOdemeTipi";
            cmbOdemeTipi.Size = new Size(151, 28);
            cmbOdemeTipi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 127);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Tutar:";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(241, 124);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(151, 27);
            txtTutar.TabIndex = 3;
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.Location = new Point(241, 205);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(120, 29);
            btnOdemeYap.TabIndex = 4;
            btnOdemeYap.Text = "ÖDEME YAP";
            btnOdemeYap.UseVisualStyleBackColor = true;
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(51, 333);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(52, 20);
            lblSonuc.TabIndex = 5;
            lblSonuc.Text = "Sonuç:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 396);
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

        private Label label1;
        private ComboBox cmbOdemeTipi;
        private Label label2;
        private TextBox txtTutar;
        private Button btnOdemeYap;
        private Label lblSonuc;
        
    }
}
