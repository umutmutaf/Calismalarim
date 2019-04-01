namespace Market
{
    partial class Form1
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
            this.TbKullaniciAdi = new System.Windows.Forms.TextBox();
            this.TbSifre = new System.Windows.Forms.TextBox();
            this.BtnKayitOl = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnKurumsalSatis = new System.Windows.Forms.Button();
            this.BtnBireyselSatis = new System.Windows.Forms.Button();
            this.LbSatis = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnSatisTarihiGecmis = new System.Windows.Forms.Button();
            this.BtnTarihiGecmis = new System.Windows.Forms.Button();
            this.LbSatisTarih = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LbFiyat = new System.Windows.Forms.ListBox();
            this.TbFiyat = new System.Windows.Forms.TextBox();
            this.BtnFiyatiDusuk = new System.Windows.Forms.Button();
            this.BtnFiyatiYuksek = new System.Windows.Forms.Button();
            this.BtnBireyselSatisAdedi = new System.Windows.Forms.Button();
            this.BtnKurumsalSatisAdedi = new System.Windows.Forms.Button();
            this.BtnTumSatislardanKazanilan = new System.Windows.Forms.Button();
            this.BtnBireyselCiro = new System.Windows.Forms.Button();
            this.BtnKurumsalCiro = new System.Windows.Forms.Button();
            this.BtnOrtalamaSatisFiyati = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbKullaniciAdi
            // 
            this.TbKullaniciAdi.Location = new System.Drawing.Point(35, 34);
            this.TbKullaniciAdi.Name = "TbKullaniciAdi";
            this.TbKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.TbKullaniciAdi.TabIndex = 0;
            // 
            // TbSifre
            // 
            this.TbSifre.Location = new System.Drawing.Point(35, 60);
            this.TbSifre.Name = "TbSifre";
            this.TbSifre.PasswordChar = '*';
            this.TbSifre.Size = new System.Drawing.Size(100, 20);
            this.TbSifre.TabIndex = 0;
            // 
            // BtnKayitOl
            // 
            this.BtnKayitOl.Location = new System.Drawing.Point(44, 103);
            this.BtnKayitOl.Name = "BtnKayitOl";
            this.BtnKayitOl.Size = new System.Drawing.Size(75, 23);
            this.BtnKayitOl.TabIndex = 1;
            this.BtnKayitOl.Text = "Kayıt Ol";
            this.BtnKayitOl.UseVisualStyleBackColor = true;
            this.BtnKayitOl.Click += new System.EventHandler(this.BtnKayitOl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbKullaniciAdi);
            this.groupBox1.Controls.Add(this.BtnGirisYap);
            this.groupBox1.Controls.Add(this.BtnKayitOl);
            this.groupBox1.Controls.Add(this.TbSifre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 170);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Soru1";
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Location = new System.Drawing.Point(44, 132);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(75, 23);
            this.BtnGirisYap.TabIndex = 1;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = true;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnOrtalamaSatisFiyati);
            this.groupBox2.Controls.Add(this.BtnKurumsalCiro);
            this.groupBox2.Controls.Add(this.BtnBireyselCiro);
            this.groupBox2.Controls.Add(this.BtnTumSatislardanKazanilan);
            this.groupBox2.Controls.Add(this.BtnKurumsalSatisAdedi);
            this.groupBox2.Controls.Add(this.BtnBireyselSatisAdedi);
            this.groupBox2.Controls.Add(this.BtnKurumsalSatis);
            this.groupBox2.Controls.Add(this.BtnBireyselSatis);
            this.groupBox2.Controls.Add(this.LbSatis);
            this.groupBox2.Location = new System.Drawing.Point(281, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 204);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Soru2";
            // 
            // BtnKurumsalSatis
            // 
            this.BtnKurumsalSatis.Location = new System.Drawing.Point(148, 139);
            this.BtnKurumsalSatis.Name = "BtnKurumsalSatis";
            this.BtnKurumsalSatis.Size = new System.Drawing.Size(154, 23);
            this.BtnKurumsalSatis.TabIndex = 1;
            this.BtnKurumsalSatis.Tag = "";
            this.BtnKurumsalSatis.Text = "Kurumsal Satışları Göster";
            this.BtnKurumsalSatis.UseVisualStyleBackColor = true;
            this.BtnKurumsalSatis.Click += new System.EventHandler(this.BtnKurumsalSatis_Click);
            // 
            // BtnBireyselSatis
            // 
            this.BtnBireyselSatis.Location = new System.Drawing.Point(17, 138);
            this.BtnBireyselSatis.Name = "BtnBireyselSatis";
            this.BtnBireyselSatis.Size = new System.Drawing.Size(125, 23);
            this.BtnBireyselSatis.TabIndex = 1;
            this.BtnBireyselSatis.Tag = "";
            this.BtnBireyselSatis.Text = "Bireysel Satışları Göster";
            this.BtnBireyselSatis.UseVisualStyleBackColor = true;
            this.BtnBireyselSatis.Click += new System.EventHandler(this.BtnBireyselSatis_Click);
            // 
            // LbSatis
            // 
            this.LbSatis.FormattingEnabled = true;
            this.LbSatis.Location = new System.Drawing.Point(17, 25);
            this.LbSatis.Name = "LbSatis";
            this.LbSatis.Size = new System.Drawing.Size(285, 108);
            this.LbSatis.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnSatisTarihiGecmis);
            this.groupBox3.Controls.Add(this.BtnTarihiGecmis);
            this.groupBox3.Controls.Add(this.LbSatisTarih);
            this.groupBox3.Location = new System.Drawing.Point(12, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 185);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Soru3";
            // 
            // BtnSatisTarihiGecmis
            // 
            this.BtnSatisTarihiGecmis.Location = new System.Drawing.Point(148, 139);
            this.BtnSatisTarihiGecmis.Name = "BtnSatisTarihiGecmis";
            this.BtnSatisTarihiGecmis.Size = new System.Drawing.Size(154, 40);
            this.BtnSatisTarihiGecmis.TabIndex = 1;
            this.BtnSatisTarihiGecmis.Tag = "";
            this.BtnSatisTarihiGecmis.Text = "Satilirken Tarihi Geçmiş Olan Ürünler";
            this.BtnSatisTarihiGecmis.UseVisualStyleBackColor = true;
            this.BtnSatisTarihiGecmis.Click += new System.EventHandler(this.BtnSatisTarihiGecmis_Click);
            // 
            // BtnTarihiGecmis
            // 
            this.BtnTarihiGecmis.Location = new System.Drawing.Point(17, 139);
            this.BtnTarihiGecmis.Name = "BtnTarihiGecmis";
            this.BtnTarihiGecmis.Size = new System.Drawing.Size(125, 40);
            this.BtnTarihiGecmis.TabIndex = 1;
            this.BtnTarihiGecmis.Tag = "";
            this.BtnTarihiGecmis.Text = "Tarihi Geçmiş Ürünler";
            this.BtnTarihiGecmis.UseVisualStyleBackColor = true;
            this.BtnTarihiGecmis.Click += new System.EventHandler(this.BtnTarihiGecmis_Click);
            // 
            // LbSatisTarih
            // 
            this.LbSatisTarih.FormattingEnabled = true;
            this.LbSatisTarih.Location = new System.Drawing.Point(17, 25);
            this.LbSatisTarih.Name = "LbSatisTarih";
            this.LbSatisTarih.Size = new System.Drawing.Size(285, 108);
            this.LbSatisTarih.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.LbFiyat);
            this.groupBox4.Controls.Add(this.TbFiyat);
            this.groupBox4.Controls.Add(this.BtnFiyatiDusuk);
            this.groupBox4.Controls.Add(this.BtnFiyatiYuksek);
            this.groupBox4.Location = new System.Drawing.Point(364, 231);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(438, 170);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Soru4";
            // 
            // LbFiyat
            // 
            this.LbFiyat.FormattingEnabled = true;
            this.LbFiyat.Location = new System.Drawing.Point(167, 19);
            this.LbFiyat.Name = "LbFiyat";
            this.LbFiyat.Size = new System.Drawing.Size(238, 147);
            this.LbFiyat.TabIndex = 2;
            // 
            // TbFiyat
            // 
            this.TbFiyat.Location = new System.Drawing.Point(35, 34);
            this.TbFiyat.Name = "TbFiyat";
            this.TbFiyat.Size = new System.Drawing.Size(100, 20);
            this.TbFiyat.TabIndex = 0;
            // 
            // BtnFiyatiDusuk
            // 
            this.BtnFiyatiDusuk.Location = new System.Drawing.Point(35, 105);
            this.BtnFiyatiDusuk.Name = "BtnFiyatiDusuk";
            this.BtnFiyatiDusuk.Size = new System.Drawing.Size(100, 23);
            this.BtnFiyatiDusuk.TabIndex = 1;
            this.BtnFiyatiDusuk.Text = "Fiyatı Düşük";
            this.BtnFiyatiDusuk.UseVisualStyleBackColor = true;
            this.BtnFiyatiDusuk.Click += new System.EventHandler(this.BtnFiyatiDusuk_Click);
            // 
            // BtnFiyatiYuksek
            // 
            this.BtnFiyatiYuksek.Location = new System.Drawing.Point(35, 76);
            this.BtnFiyatiYuksek.Name = "BtnFiyatiYuksek";
            this.BtnFiyatiYuksek.Size = new System.Drawing.Size(100, 23);
            this.BtnFiyatiYuksek.TabIndex = 1;
            this.BtnFiyatiYuksek.Text = "Fiyati Yüksek";
            this.BtnFiyatiYuksek.UseVisualStyleBackColor = true;
            this.BtnFiyatiYuksek.Click += new System.EventHandler(this.BtnFiyatiYuksek_Click);
            // 
            // BtnBireyselSatisAdedi
            // 
            this.BtnBireyselSatisAdedi.Location = new System.Drawing.Point(308, 25);
            this.BtnBireyselSatisAdedi.Name = "BtnBireyselSatisAdedi";
            this.BtnBireyselSatisAdedi.Size = new System.Drawing.Size(174, 41);
            this.BtnBireyselSatisAdedi.TabIndex = 2;
            this.BtnBireyselSatisAdedi.Text = "Bireysel Satış Adedi";
            this.BtnBireyselSatisAdedi.UseVisualStyleBackColor = true;
            this.BtnBireyselSatisAdedi.Click += new System.EventHandler(this.BtnBireyselSatisAdedi_Click);
            // 
            // BtnKurumsalSatisAdedi
            // 
            this.BtnKurumsalSatisAdedi.Location = new System.Drawing.Point(308, 72);
            this.BtnKurumsalSatisAdedi.Name = "BtnKurumsalSatisAdedi";
            this.BtnKurumsalSatisAdedi.Size = new System.Drawing.Size(174, 41);
            this.BtnKurumsalSatisAdedi.TabIndex = 3;
            this.BtnKurumsalSatisAdedi.Text = "Kurumsal Satıs Adedi";
            this.BtnKurumsalSatisAdedi.UseVisualStyleBackColor = true;
            this.BtnKurumsalSatisAdedi.Click += new System.EventHandler(this.BtnKurumsalSatisAdedi_Click);
            // 
            // BtnTumSatislardanKazanilan
            // 
            this.BtnTumSatislardanKazanilan.Location = new System.Drawing.Point(308, 121);
            this.BtnTumSatislardanKazanilan.Name = "BtnTumSatislardanKazanilan";
            this.BtnTumSatislardanKazanilan.Size = new System.Drawing.Size(174, 41);
            this.BtnTumSatislardanKazanilan.TabIndex = 4;
            this.BtnTumSatislardanKazanilan.Text = "Tüm Satışlardan Kazanılan";
            this.BtnTumSatislardanKazanilan.UseVisualStyleBackColor = true;
            this.BtnTumSatislardanKazanilan.Click += new System.EventHandler(this.BtnTumSatislardanKazanilan_Click);
            // 
            // BtnBireyselCiro
            // 
            this.BtnBireyselCiro.Location = new System.Drawing.Point(17, 167);
            this.BtnBireyselCiro.Name = "BtnBireyselCiro";
            this.BtnBireyselCiro.Size = new System.Drawing.Size(143, 23);
            this.BtnBireyselCiro.TabIndex = 3;
            this.BtnBireyselCiro.Text = "Bireysel Satışları Hesapla";
            this.BtnBireyselCiro.UseVisualStyleBackColor = true;
            this.BtnBireyselCiro.Click += new System.EventHandler(this.BtnBireyselCiro_Click);
            // 
            // BtnKurumsalCiro
            // 
            this.BtnKurumsalCiro.Location = new System.Drawing.Point(166, 168);
            this.BtnKurumsalCiro.Name = "BtnKurumsalCiro";
            this.BtnKurumsalCiro.Size = new System.Drawing.Size(143, 23);
            this.BtnKurumsalCiro.TabIndex = 5;
            this.BtnKurumsalCiro.Text = "Kurumsal Satışları Hesapla";
            this.BtnKurumsalCiro.UseVisualStyleBackColor = true;
            this.BtnKurumsalCiro.Click += new System.EventHandler(this.BtnKurumsalCiro_Click);
            // 
            // BtnOrtalamaSatisFiyati
            // 
            this.BtnOrtalamaSatisFiyati.Location = new System.Drawing.Point(315, 167);
            this.BtnOrtalamaSatisFiyati.Name = "BtnOrtalamaSatisFiyati";
            this.BtnOrtalamaSatisFiyati.Size = new System.Drawing.Size(143, 23);
            this.BtnOrtalamaSatisFiyati.TabIndex = 6;
            this.BtnOrtalamaSatisFiyati.Text = "Ortalama Satış Fiyatı";
            this.BtnOrtalamaSatisFiyati.UseVisualStyleBackColor = true;
            this.BtnOrtalamaSatisFiyati.Click += new System.EventHandler(this.BtnOrtalamaSatisFiyati_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "GroupBy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "FirstOrDefault";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TbKullaniciAdi;
        private System.Windows.Forms.TextBox TbSifre;
        private System.Windows.Forms.Button BtnKayitOl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnKurumsalSatis;
        private System.Windows.Forms.Button BtnBireyselSatis;
        private System.Windows.Forms.ListBox LbSatis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnSatisTarihiGecmis;
        private System.Windows.Forms.Button BtnTarihiGecmis;
        private System.Windows.Forms.ListBox LbSatisTarih;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox LbFiyat;
        private System.Windows.Forms.TextBox TbFiyat;
        private System.Windows.Forms.Button BtnFiyatiDusuk;
        private System.Windows.Forms.Button BtnFiyatiYuksek;
        private System.Windows.Forms.Button BtnKurumsalSatisAdedi;
        private System.Windows.Forms.Button BtnBireyselSatisAdedi;
        private System.Windows.Forms.Button BtnTumSatislardanKazanilan;
        private System.Windows.Forms.Button BtnKurumsalCiro;
        private System.Windows.Forms.Button BtnBireyselCiro;
        private System.Windows.Forms.Button BtnOrtalamaSatisFiyati;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

