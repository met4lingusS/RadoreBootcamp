namespace SerializationRadore
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAd = new TextBox();
            txtTelefon = new TextBox();
            txtDepartman = new TextBox();
            txtMaas = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnSerilestir = new Button();
            btnDeserilestir = new Button();
            btnJsonSerialize = new Button();
            btnJsonDeserialize = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 103);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 150);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Telefon:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 201);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 2;
            label3.Text = "Doğum Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 254);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 3;
            label4.Text = "Departman:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 301);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 4;
            label5.Text = "Maaş:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(356, 100);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 5;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(356, 147);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(125, 27);
            txtTelefon.TabIndex = 6;
            // 
            // txtDepartman
            // 
            txtDepartman.Location = new Point(356, 251);
            txtDepartman.Name = "txtDepartman";
            txtDepartman.Size = new Size(125, 27);
            txtDepartman.TabIndex = 7;
            // 
            // txtMaas
            // 
            txtMaas.Location = new Point(356, 298);
            txtMaas.Name = "txtMaas";
            txtMaas.Size = new Size(125, 27);
            txtMaas.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(356, 196);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // btnSerilestir
            // 
            btnSerilestir.Location = new Point(146, 359);
            btnSerilestir.Name = "btnSerilestir";
            btnSerilestir.Size = new Size(94, 29);
            btnSerilestir.TabIndex = 10;
            btnSerilestir.Text = "Serialize";
            btnSerilestir.UseVisualStyleBackColor = true;
            btnSerilestir.Click += btnSerilestir_Click;
            // 
            // btnDeserilestir
            // 
            btnDeserilestir.Location = new Point(387, 359);
            btnDeserilestir.Name = "btnDeserilestir";
            btnDeserilestir.Size = new Size(94, 29);
            btnDeserilestir.TabIndex = 11;
            btnDeserilestir.Text = "Deserialize";
            btnDeserilestir.UseVisualStyleBackColor = true;
            btnDeserilestir.Click += btnDeserilestir_Click;
            // 
            // btnJsonSerialize
            // 
            btnJsonSerialize.Location = new Point(609, 334);
            btnJsonSerialize.Name = "btnJsonSerialize";
            btnJsonSerialize.Size = new Size(144, 29);
            btnJsonSerialize.TabIndex = 12;
            btnJsonSerialize.Text = "JSON - Serialize";
            btnJsonSerialize.UseVisualStyleBackColor = true;
            btnJsonSerialize.Click += btnJsonSerialize_Click;
            // 
            // btnJsonDeserialize
            // 
            btnJsonDeserialize.Location = new Point(609, 392);
            btnJsonDeserialize.Name = "btnJsonDeserialize";
            btnJsonDeserialize.Size = new Size(144, 29);
            btnJsonDeserialize.TabIndex = 13;
            btnJsonDeserialize.Text = "JSON - Deserialize";
            btnJsonDeserialize.UseVisualStyleBackColor = true;
            btnJsonDeserialize.Click += btnJsonDeserialize_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnJsonDeserialize);
            Controls.Add(btnJsonSerialize);
            Controls.Add(btnDeserilestir);
            Controls.Add(btnSerilestir);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtMaas);
            Controls.Add(txtDepartman);
            Controls.Add(txtTelefon);
            Controls.Add(txtAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAd;
        private TextBox txtTelefon;
        private TextBox txtDepartman;
        private TextBox txtMaas;
        private DateTimePicker dateTimePicker1;
        private Button btnSerilestir;
        private Button btnDeserilestir;
        private Button btnJsonSerialize;
        private Button btnJsonDeserialize;
    }
}
