namespace tren
{
    partial class frmKrediKarti
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
            this.btnBilgileriAl = new System.Windows.Forms.Button();
            this.txtKartno = new System.Windows.Forms.TextBox();
            this.txtKartAdSoyad = new System.Windows.Forms.TextBox();
            this.txtSKT = new System.Windows.Forms.TextBox();
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBilgileriAl
            // 
            this.btnBilgileriAl.Location = new System.Drawing.Point(12, 116);
            this.btnBilgileriAl.Name = "btnBilgileriAl";
            this.btnBilgileriAl.Size = new System.Drawing.Size(263, 23);
            this.btnBilgileriAl.TabIndex = 0;
            this.btnBilgileriAl.Text = "İşlemi Tamamla";
            this.btnBilgileriAl.UseVisualStyleBackColor = true;
            this.btnBilgileriAl.Click += new System.EventHandler(this.btnBilgileriAl_Click);
            // 
            // txtKartno
            // 
            this.txtKartno.Location = new System.Drawing.Point(12, 12);
            this.txtKartno.Name = "txtKartno";
            this.txtKartno.Size = new System.Drawing.Size(263, 20);
            this.txtKartno.TabIndex = 1;
            this.txtKartno.Text = "Kart Numaranızı Giriniz...";
            this.txtKartno.WordWrap = false;
            this.txtKartno.Click += new System.EventHandler(this.txtKartno_Click);
            // 
            // txtKartAdSoyad
            // 
            this.txtKartAdSoyad.Location = new System.Drawing.Point(12, 38);
            this.txtKartAdSoyad.Name = "txtKartAdSoyad";
            this.txtKartAdSoyad.Size = new System.Drawing.Size(263, 20);
            this.txtKartAdSoyad.TabIndex = 2;
            this.txtKartAdSoyad.Text = "Kart Üzerindeki Ad Soyadı Giriniz...";
            this.txtKartAdSoyad.Click += new System.EventHandler(this.txtKartAdSoyad_Click);
            // 
            // txtSKT
            // 
            this.txtSKT.Location = new System.Drawing.Point(12, 64);
            this.txtSKT.Name = "txtSKT";
            this.txtSKT.Size = new System.Drawing.Size(263, 20);
            this.txtSKT.TabIndex = 3;
            this.txtSKT.Text = "Kart Üzerindeki SKT Giriniz";
            this.txtSKT.Click += new System.EventHandler(this.txtSKT_Click);
            // 
            // txtCVC
            // 
            this.txtCVC.Location = new System.Drawing.Point(12, 90);
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(100, 20);
            this.txtCVC.TabIndex = 4;
            this.txtCVC.Text = "CVC Giriniz";
            this.txtCVC.Click += new System.EventHandler(this.txtCVC_Click);
            // 
            // frmKrediKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 145);
            this.Controls.Add(this.txtCVC);
            this.Controls.Add(this.txtSKT);
            this.Controls.Add(this.txtKartAdSoyad);
            this.Controls.Add(this.txtKartno);
            this.Controls.Add(this.btnBilgileriAl);
            this.Name = "frmKrediKarti";
            this.Text = "frmKrediKarti";
            this.Load += new System.EventHandler(this.frmKrediKarti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBilgileriAl;
        private System.Windows.Forms.TextBox txtKartno;
        private System.Windows.Forms.TextBox txtKartAdSoyad;
        private System.Windows.Forms.TextBox txtSKT;
        private System.Windows.Forms.TextBox txtCVC;
    }
}