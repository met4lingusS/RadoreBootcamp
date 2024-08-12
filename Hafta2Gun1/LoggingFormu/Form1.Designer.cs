namespace LoggingFormu
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
            cmbLogTipi = new ComboBox();
            label2 = new Label();
            txtKayitNotu = new TextBox();
            btnLogKaydet = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 89);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Log Tipi: ";
            // 
            // cmbLogTipi
            // 
            cmbLogTipi.FormattingEnabled = true;
            cmbLogTipi.Items.AddRange(new object[] { "Seçiniz", "CSVLog", "DBLog", "JSONLog", "XMLLog", "" });
            cmbLogTipi.Location = new Point(213, 86);
            cmbLogTipi.Name = "cmbLogTipi";
            cmbLogTipi.Size = new Size(151, 28);
            cmbLogTipi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 159);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 2;
            label2.Text = "Kayıt Notu:";
            // 
            // txtKayitNotu
            // 
            txtKayitNotu.Location = new Point(213, 156);
            txtKayitNotu.Name = "txtKayitNotu";
            txtKayitNotu.Size = new Size(283, 27);
            txtKayitNotu.TabIndex = 3;
            // 
            // btnLogKaydet
            // 
            btnLogKaydet.Location = new Point(561, 217);
            btnLogKaydet.Name = "btnLogKaydet";
            btnLogKaydet.Size = new Size(151, 49);
            btnLogKaydet.TabIndex = 4;
            btnLogKaydet.Text = "LOG KAYDET";
            btnLogKaydet.UseVisualStyleBackColor = true;
            btnLogKaydet.Click += btnLogKaydet_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(90, 231);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(52, 20);
            lblSonuc.TabIndex = 5;
            lblSonuc.Text = "Sonuç:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSonuc);
            Controls.Add(btnLogKaydet);
            Controls.Add(txtKayitNotu);
            Controls.Add(label2);
            Controls.Add(cmbLogTipi);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbLogTipi;
        private Label label2;
        private TextBox txtKayitNotu;
        private Button btnLogKaydet;
        private Label lblSonuc;
    }
}
