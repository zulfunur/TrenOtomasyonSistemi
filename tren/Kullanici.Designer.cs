namespace tren
{
    partial class Kullanici
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblHg = new System.Windows.Forms.Label();
            this.btnYenii = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(198, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGiris.Location = new System.Drawing.Point(198, 213);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(100, 23);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(87, 96);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(67, 13);
            this.lblKullaniciAdi.TabIndex = 3;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            this.lblKullaniciAdi.Click += new System.EventHandler(this.lblKullaniciAdi_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(87, 155);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(31, 13);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblHg
            // 
            this.lblHg.AutoSize = true;
            this.lblHg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblHg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHg.Location = new System.Drawing.Point(87, 19);
            this.lblHg.Name = "lblHg";
            this.lblHg.Size = new System.Drawing.Size(211, 31);
            this.lblHg.TabIndex = 5;
            this.lblHg.Text = "HOŞGELDİNİZ";
            // 
            // btnYenii
            // 
            this.btnYenii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnYenii.Location = new System.Drawing.Point(81, 213);
            this.btnYenii.Name = "btnYenii";
            this.btnYenii.Size = new System.Drawing.Size(100, 23);
            this.btnYenii.TabIndex = 6;
            this.btnYenii.Text = "Yeni Oluştur";
            this.btnYenii.UseVisualStyleBackColor = false;
            this.btnYenii.Click += new System.EventHandler(this.btnYenii_Click);
            // 
            // Kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(462, 330);
            this.Controls.Add(this.btnYenii);
            this.Controls.Add(this.lblHg);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Kullanici";
            this.Text = "Kullanici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblHg;
        private System.Windows.Forms.Button btnYenii;
    }
}