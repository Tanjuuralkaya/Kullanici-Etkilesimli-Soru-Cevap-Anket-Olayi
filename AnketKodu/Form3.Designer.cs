namespace AnketKodu
{
    partial class Form3
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
            this.lblSoru = new System.Windows.Forms.Label();
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.lblCevapturu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsecme = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSoru
            // 
            this.lblSoru.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoru.Location = new System.Drawing.Point(19, 30);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(63, 20);
            this.lblSoru.TabIndex = 0;
            this.lblSoru.Text = "Soru   :";
            // 
            // txtSoru
            // 
            this.txtSoru.Location = new System.Drawing.Point(116, 12);
            this.txtSoru.Multiline = true;
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(592, 60);
            this.txtSoru.TabIndex = 1;
            // 
            // lblCevapturu
            // 
            this.lblCevapturu.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCevapturu.Location = new System.Drawing.Point(21, 127);
            this.lblCevapturu.Name = "lblCevapturu";
            this.lblCevapturu.Size = new System.Drawing.Size(89, 23);
            this.lblCevapturu.TabIndex = 2;
            this.lblCevapturu.Text = "Cevap Türü  :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.ForeColor = System.Drawing.Color.Purple;
            this.panel1.Location = new System.Drawing.Point(116, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 103);
            this.panel1.TabIndex = 3;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 83);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(94, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Sayısal Değerli";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Çoklu Seçenekli";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Evet/Hayır";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton5);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Location = new System.Drawing.Point(489, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 86);
            this.panel2.TabIndex = 3;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(3, 52);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Gerekli Değil";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 18);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Gerekli";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(365, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerekli mi?";
            // 
            // lblsecme
            // 
            this.lblsecme.AutoSize = true;
            this.lblsecme.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsecme.Location = new System.Drawing.Point(21, 228);
            this.lblsecme.Name = "lblsecme";
            this.lblsecme.Size = new System.Drawing.Size(89, 18);
            this.lblsecme.TabIndex = 4;
            this.lblsecme.Text = "Seçme Şekli :";
            this.lblsecme.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton7);
            this.panel3.Controls.Add(this.radioButton6);
            this.panel3.Location = new System.Drawing.Point(116, 199);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 76);
            this.panel3.TabIndex = 5;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(3, 40);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(121, 17);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Tek Cevap Seçebilir";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(3, 17);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(164, 17);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Birden Fazla Cevap Seçilebilir";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Anket Seç:";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(116, 325);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(75, 23);
            this.btnGonder.TabIndex = 9;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 281);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 437);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblsecme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCevapturu);
            this.Controls.Add(this.txtSoru);
            this.Controls.Add(this.lblSoru);
            this.ForeColor = System.Drawing.Color.Purple;
            this.Name = "Form3";
            this.Text = "Anket Yönetimi";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.Label lblCevapturu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsecme;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox txtSoru;
    }
}