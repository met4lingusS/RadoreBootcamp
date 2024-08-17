using RegisteringClassLibrary.AttributeClasses;

namespace RegisteringForm
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
            btnYeniForm = new Button();
            btnRegisterForm = new Button();
            lblSonuc = new Label();
            txtAnswer3 = new TextBox();
            txtAnswer2 = new TextBox();
            txtAnswer1 = new TextBox();
            lblQ3 = new Label();
            lblQ2 = new Label();
            lblQ1 = new Label();
            cmbFormType = new ComboBox();
            label1 = new Label();
            btnSelectFormType = new Button();
            SuspendLayout();
            // 
            // btnYeniForm
            // 
            btnYeniForm.Location = new Point(647, 334);
            btnYeniForm.Name = "btnYeniForm";
            btnYeniForm.Size = new Size(129, 95);
            btnYeniForm.TabIndex = 32;
            btnYeniForm.Text = "Yeni Form Oluştur";
            btnYeniForm.UseVisualStyleBackColor = true;
            btnYeniForm.Click += btnYeniForm_Click;
            // 
            // btnRegisterForm
            // 
            btnRegisterForm.Location = new Point(423, 334);
            btnRegisterForm.Name = "btnRegisterForm";
            btnRegisterForm.Size = new Size(124, 95);
            btnRegisterForm.TabIndex = 31;
            btnRegisterForm.Text = "Formu Kaydet";
            btnRegisterForm.UseVisualStyleBackColor = true;
            btnRegisterForm.Click += btnFormKaydet_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(42, 313);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(52, 20);
            lblSonuc.TabIndex = 30;
            lblSonuc.Text = "Sonuç:";
            // 
            // txtAnswer3
            // 
            txtAnswer3.Location = new Point(354, 230);
            txtAnswer3.Name = "txtAnswer3";
            txtAnswer3.Size = new Size(193, 27);
            txtAnswer3.TabIndex = 29;
            // 
            // txtAnswer2
            // 
            txtAnswer2.Location = new Point(354, 157);
            txtAnswer2.Name = "txtAnswer2";
            txtAnswer2.Size = new Size(193, 27);
            txtAnswer2.TabIndex = 28;
            // 
            // txtAnswer1
            // 
            txtAnswer1.Location = new Point(354, 94);
            txtAnswer1.Name = "txtAnswer1";
            txtAnswer1.Size = new Size(193, 27);
            txtAnswer1.TabIndex = 27;
            // 
            // lblQ3
            // 
            lblQ3.AutoSize = true;
            lblQ3.BackColor = SystemColors.Control;
            lblQ3.Location = new Point(31, 233);
            lblQ3.Name = "lblQ3";
            lblQ3.Size = new Size(54, 20);
            lblQ3.TabIndex = 26;
            lblQ3.Text = "Soru 3:";
            // 
            // lblQ2
            // 
            lblQ2.AutoSize = true;
            lblQ2.BackColor = SystemColors.Control;
            lblQ2.Location = new Point(31, 160);
            lblQ2.Name = "lblQ2";
            lblQ2.Size = new Size(54, 20);
            lblQ2.TabIndex = 25;
            lblQ2.Text = "Soru 2:";
            // 
            // lblQ1
            // 
            lblQ1.AutoSize = true;
            lblQ1.BackColor = SystemColors.Control;
            lblQ1.Location = new Point(31, 97);
            lblQ1.Name = "lblQ1";
            lblQ1.Size = new Size(54, 20);
            lblQ1.TabIndex = 24;
            lblQ1.Text = "Soru 1:";
            // 
            // cmbFormType
            // 
            cmbFormType.FormattingEnabled = true;
            cmbFormType.Location = new Point(354, 26);
            cmbFormType.Name = "cmbFormType";
            cmbFormType.Size = new Size(193, 28);
            cmbFormType.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 29);
            label1.Name = "label1";
            label1.Size = new Size(238, 20);
            label1.TabIndex = 22;
            label1.Text = "Oluşturmak istediğiniz kayıt formu:";
            // 
            // btnSelectFormType
            // 
            btnSelectFormType.Location = new Point(601, 21);
            btnSelectFormType.Name = "btnSelectFormType";
            btnSelectFormType.Size = new Size(149, 37);
            btnSelectFormType.TabIndex = 33;
            btnSelectFormType.Text = "Form Seç";
            btnSelectFormType.UseVisualStyleBackColor = true;
            btnSelectFormType.Click += btnSelectFormType_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSelectFormType);
            Controls.Add(btnYeniForm);
            Controls.Add(btnRegisterForm);
            Controls.Add(lblSonuc);
            Controls.Add(txtAnswer3);
            Controls.Add(txtAnswer2);
            Controls.Add(txtAnswer1);
            Controls.Add(lblQ3);
            Controls.Add(lblQ2);
            Controls.Add(lblQ1);
            Controls.Add(cmbFormType);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        [RegisteringRequirements]
        private TextBox txtAnswer3;
        
        [RegisteringRequirements]
        private TextBox txtAnswer2;
        
        [RegisteringRequirements]
        private TextBox txtAnswer1;

        private Button btnYeniForm;
        private Button btnRegisterForm;
        private Label lblSonuc;
        private Label lblQ3;
        private Label lblQ2;
        private Label lblQ1;
        private ComboBox cmbFormType;
        private Label label1;
        private Button btnSelectFormType;
    }
}
