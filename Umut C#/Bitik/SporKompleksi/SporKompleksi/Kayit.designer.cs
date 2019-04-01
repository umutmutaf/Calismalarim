namespace SporKompleksi
{
    partial class Kayit
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
            this.LinkLblGiriseDon = new System.Windows.Forms.LinkLabel();
            this.BtnKayitKaydet = new System.Windows.Forms.Button();
            this.TxtKayitSifre = new System.Windows.Forms.TextBox();
            this.TxtKayitKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKayitTelNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LinkLblGiriseDon
            // 
            this.LinkLblGiriseDon.AutoSize = true;
            this.LinkLblGiriseDon.BackColor = System.Drawing.Color.Transparent;
            this.LinkLblGiriseDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LinkLblGiriseDon.LinkColor = System.Drawing.Color.White;
            this.LinkLblGiriseDon.Location = new System.Drawing.Point(84, 199);
            this.LinkLblGiriseDon.Name = "LinkLblGiriseDon";
            this.LinkLblGiriseDon.Size = new System.Drawing.Size(80, 13);
            this.LinkLblGiriseDon.TabIndex = 12;
            this.LinkLblGiriseDon.TabStop = true;
            this.LinkLblGiriseDon.Text = "Giriş Menüsü";
            this.LinkLblGiriseDon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblGiriseDon_LinkClicked);
            // 
            // BtnKayitKaydet
            // 
            this.BtnKayitKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKayitKaydet.Location = new System.Drawing.Point(75, 136);
            this.BtnKayitKaydet.Name = "BtnKayitKaydet";
            this.BtnKayitKaydet.Size = new System.Drawing.Size(100, 47);
            this.BtnKayitKaydet.TabIndex = 11;
            this.BtnKayitKaydet.Text = "Kaydet";
            this.BtnKayitKaydet.UseVisualStyleBackColor = true;
            this.BtnKayitKaydet.Click += new System.EventHandler(this.BtnKayitKaydet_Click);
            // 
            // TxtKayitSifre
            // 
            this.TxtKayitSifre.Location = new System.Drawing.Point(130, 69);
            this.TxtKayitSifre.Name = "TxtKayitSifre";
            this.TxtKayitSifre.Size = new System.Drawing.Size(100, 20);
            this.TxtKayitSifre.TabIndex = 10;
            this.TxtKayitSifre.UseSystemPasswordChar = true;
            // 
            // TxtKayitKullaniciAdi
            // 
            this.TxtKayitKullaniciAdi.Location = new System.Drawing.Point(130, 38);
            this.TxtKayitKullaniciAdi.Name = "TxtKayitKullaniciAdi";
            this.TxtKayitKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.TxtKayitKullaniciAdi.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // TxtKayitTelNo
            // 
            this.TxtKayitTelNo.Location = new System.Drawing.Point(130, 100);
            this.TxtKayitTelNo.Name = "TxtKayitTelNo";
            this.TxtKayitTelNo.Size = new System.Drawing.Size(100, 20);
            this.TxtKayitTelNo.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefon No";
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SporKompleksi.Properties.Resources.arka;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(255, 244);
            this.Controls.Add(this.TxtKayitTelNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LinkLblGiriseDon);
            this.Controls.Add(this.BtnKayitKaydet);
            this.Controls.Add(this.TxtKayitSifre);
            this.Controls.Add(this.TxtKayitKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LinkLblGiriseDon;
        private System.Windows.Forms.Button BtnKayitKaydet;
        private System.Windows.Forms.TextBox TxtKayitSifre;
        private System.Windows.Forms.TextBox TxtKayitKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKayitTelNo;
        private System.Windows.Forms.Label label3;
    }
}