namespace tren
{
    partial class YeniKullaniciOlustur
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdSoyadd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifree = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKullaniciAdii = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(165, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoş Geldiniz...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Ad Soyad:";
            // 
            // txtAdSoyadd
            // 
            this.txtAdSoyadd.Location = new System.Drawing.Point(232, 78);
            this.txtAdSoyadd.Name = "txtAdSoyadd";
            this.txtAdSoyadd.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyadd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "*Tel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "*TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "*Şifre Oluşturunuz:";
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.Location = new System.Drawing.Point(232, 120);
            this.maskedTextBoxTel.Mask = "(999) 000-0000";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxTel.TabIndex = 7;
            // 
            // maskedTextBoxTC
            // 
            this.maskedTextBoxTC.Location = new System.Drawing.Point(232, 164);
            this.maskedTextBoxTC.Mask = "00000000000";
            this.maskedTextBoxTC.Name = "maskedTextBoxTC";
            this.maskedTextBoxTC.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxTC.TabIndex = 8;
            // 
            // TxtSifree
            // 
            this.TxtSifree.Location = new System.Drawing.Point(232, 239);
            this.TxtSifree.Name = "TxtSifree";
            this.TxtSifree.Size = new System.Drawing.Size(100, 20);
            this.TxtSifree.TabIndex = 9;
            this.TxtSifree.TextChanged += new System.EventHandler(this.txtSifree_TextChanged);
            this.TxtSifree.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSifree_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Yeni Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "*Kullanıcı Adı:";
            // 
            // txtKullaniciAdii
            // 
            this.txtKullaniciAdii.Location = new System.Drawing.Point(232, 202);
            this.txtKullaniciAdii.Name = "txtKullaniciAdii";
            this.txtKullaniciAdii.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciAdii.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(204, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "(En az 6 karakterli, içinde en az";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(204, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = " bir küçük, bir büyük, bir de rakam)";
            // 
            // YeniKullaniciOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 347);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKullaniciAdii);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtSifree);
            this.Controls.Add(this.maskedTextBoxTC);
            this.Controls.Add(this.maskedTextBoxTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdSoyadd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YeniKullaniciOlustur";
            this.Text = "YeniKullaniciOlustur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyadd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTC;
        private System.Windows.Forms.TextBox TxtSifree;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKullaniciAdii;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}