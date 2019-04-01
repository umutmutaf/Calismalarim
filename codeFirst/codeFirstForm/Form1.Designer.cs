namespace codeFirstForm
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
            this.TbEkleAdi = new System.Windows.Forms.TextBox();
            this.TbEkleSoyadi = new System.Windows.Forms.TextBox();
            this.BtnKisiEkle = new System.Windows.Forms.Button();
            this.TbBilgiHobi = new System.Windows.Forms.TextBox();
            this.TbBilgiTel = new System.Windows.Forms.TextBox();
            this.BtnBilgiEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKisiSil = new System.Windows.Forms.Button();
            this.BtnBilgiGuncelle = new System.Windows.Forms.Button();
            this.TbBilgiAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbGuncelleAdi = new System.Windows.Forms.TextBox();
            this.TbGuncelleHobi = new System.Windows.Forms.TextBox();
            this.TbGuncelleTel = new System.Windows.Forms.TextBox();
            this.TbSilAdi = new System.Windows.Forms.TextBox();
            this.TbSilSoyadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.TbBilgiSoyadi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TbGuncelleSoyadi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbEkleAdi
            // 
            this.TbEkleAdi.Location = new System.Drawing.Point(79, 44);
            this.TbEkleAdi.Name = "TbEkleAdi";
            this.TbEkleAdi.Size = new System.Drawing.Size(100, 20);
            this.TbEkleAdi.TabIndex = 0;
            // 
            // TbEkleSoyadi
            // 
            this.TbEkleSoyadi.Location = new System.Drawing.Point(79, 80);
            this.TbEkleSoyadi.Name = "TbEkleSoyadi";
            this.TbEkleSoyadi.Size = new System.Drawing.Size(100, 20);
            this.TbEkleSoyadi.TabIndex = 0;
            // 
            // BtnKisiEkle
            // 
            this.BtnKisiEkle.Location = new System.Drawing.Point(79, 106);
            this.BtnKisiEkle.Name = "BtnKisiEkle";
            this.BtnKisiEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnKisiEkle.TabIndex = 1;
            this.BtnKisiEkle.Text = "Kişi Ekle";
            this.BtnKisiEkle.UseVisualStyleBackColor = true;
            this.BtnKisiEkle.Click += new System.EventHandler(this.BtnKisiEkle_Click);
            // 
            // TbBilgiHobi
            // 
            this.TbBilgiHobi.Location = new System.Drawing.Point(453, 79);
            this.TbBilgiHobi.Name = "TbBilgiHobi";
            this.TbBilgiHobi.Size = new System.Drawing.Size(100, 20);
            this.TbBilgiHobi.TabIndex = 0;
            // 
            // TbBilgiTel
            // 
            this.TbBilgiTel.Location = new System.Drawing.Point(453, 115);
            this.TbBilgiTel.Name = "TbBilgiTel";
            this.TbBilgiTel.Size = new System.Drawing.Size(100, 20);
            this.TbBilgiTel.TabIndex = 0;
            // 
            // BtnBilgiEkle
            // 
            this.BtnBilgiEkle.Location = new System.Drawing.Point(453, 141);
            this.BtnBilgiEkle.Name = "BtnBilgiEkle";
            this.BtnBilgiEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnBilgiEkle.TabIndex = 1;
            this.BtnBilgiEkle.Text = "Bilgi Ekle";
            this.BtnBilgiEkle.UseVisualStyleBackColor = true;
            this.BtnBilgiEkle.Click += new System.EventHandler(this.BtnBilgiEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hobi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "TelNo:";
            // 
            // btnKisiSil
            // 
            this.btnKisiSil.Location = new System.Drawing.Point(259, 106);
            this.btnKisiSil.Name = "btnKisiSil";
            this.btnKisiSil.Size = new System.Drawing.Size(75, 23);
            this.btnKisiSil.TabIndex = 1;
            this.btnKisiSil.Text = "Kişi Sil";
            this.btnKisiSil.UseVisualStyleBackColor = true;
            this.btnKisiSil.Click += new System.EventHandler(this.btnKisiSil_Click);
            // 
            // BtnBilgiGuncelle
            // 
            this.BtnBilgiGuncelle.Location = new System.Drawing.Point(668, 141);
            this.BtnBilgiGuncelle.Name = "BtnBilgiGuncelle";
            this.BtnBilgiGuncelle.Size = new System.Drawing.Size(82, 23);
            this.BtnBilgiGuncelle.TabIndex = 1;
            this.BtnBilgiGuncelle.Text = "Bilgi Güncelle";
            this.BtnBilgiGuncelle.UseVisualStyleBackColor = true;
            this.BtnBilgiGuncelle.Click += new System.EventHandler(this.BtnBilgiGuncelle_Click);
            // 
            // TbBilgiAdi
            // 
            this.TbBilgiAdi.Location = new System.Drawing.Point(453, 27);
            this.TbBilgiAdi.Name = "TbBilgiAdi";
            this.TbBilgiAdi.Size = new System.Drawing.Size(100, 20);
            this.TbBilgiAdi.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Adı:";
            // 
            // TbGuncelleAdi
            // 
            this.TbGuncelleAdi.Location = new System.Drawing.Point(668, 27);
            this.TbGuncelleAdi.Name = "TbGuncelleAdi";
            this.TbGuncelleAdi.Size = new System.Drawing.Size(100, 20);
            this.TbGuncelleAdi.TabIndex = 0;
            // 
            // TbGuncelleHobi
            // 
            this.TbGuncelleHobi.Location = new System.Drawing.Point(668, 79);
            this.TbGuncelleHobi.Name = "TbGuncelleHobi";
            this.TbGuncelleHobi.Size = new System.Drawing.Size(100, 20);
            this.TbGuncelleHobi.TabIndex = 0;
            // 
            // TbGuncelleTel
            // 
            this.TbGuncelleTel.Location = new System.Drawing.Point(668, 115);
            this.TbGuncelleTel.Name = "TbGuncelleTel";
            this.TbGuncelleTel.Size = new System.Drawing.Size(100, 20);
            this.TbGuncelleTel.TabIndex = 0;
            // 
            // TbSilAdi
            // 
            this.TbSilAdi.Location = new System.Drawing.Point(259, 44);
            this.TbSilAdi.Name = "TbSilAdi";
            this.TbSilAdi.Size = new System.Drawing.Size(100, 20);
            this.TbSilAdi.TabIndex = 0;
            // 
            // TbSilSoyadi
            // 
            this.TbSilSoyadi.Location = new System.Drawing.Point(259, 80);
            this.TbSilSoyadi.Name = "TbSilSoyadi";
            this.TbSilSoyadi.Size = new System.Drawing.Size(100, 20);
            this.TbSilSoyadi.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Adı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Soyadı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(606, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Adı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(606, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Hobi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(606, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "TelNo:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 196);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 242);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // TbBilgiSoyadi
            // 
            this.TbBilgiSoyadi.Location = new System.Drawing.Point(453, 53);
            this.TbBilgiSoyadi.Name = "TbBilgiSoyadi";
            this.TbBilgiSoyadi.Size = new System.Drawing.Size(100, 20);
            this.TbBilgiSoyadi.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(386, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Soyadı:";
            // 
            // TbGuncelleSoyadi
            // 
            this.TbGuncelleSoyadi.Location = new System.Drawing.Point(668, 53);
            this.TbGuncelleSoyadi.Name = "TbGuncelleSoyadi";
            this.TbGuncelleSoyadi.Size = new System.Drawing.Size(100, 20);
            this.TbGuncelleSoyadi.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(601, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Soyadı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBilgiEkle);
            this.Controls.Add(this.TbGuncelleTel);
            this.Controls.Add(this.TbBilgiTel);
            this.Controls.Add(this.BtnBilgiGuncelle);
            this.Controls.Add(this.btnKisiSil);
            this.Controls.Add(this.TbGuncelleHobi);
            this.Controls.Add(this.BtnKisiEkle);
            this.Controls.Add(this.TbGuncelleAdi);
            this.Controls.Add(this.TbBilgiHobi);
            this.Controls.Add(this.TbGuncelleSoyadi);
            this.Controls.Add(this.TbBilgiSoyadi);
            this.Controls.Add(this.TbBilgiAdi);
            this.Controls.Add(this.TbSilSoyadi);
            this.Controls.Add(this.TbSilAdi);
            this.Controls.Add(this.TbEkleSoyadi);
            this.Controls.Add(this.TbEkleAdi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbEkleAdi;
        private System.Windows.Forms.TextBox TbEkleSoyadi;
        private System.Windows.Forms.Button BtnKisiEkle;
        private System.Windows.Forms.TextBox TbBilgiHobi;
        private System.Windows.Forms.TextBox TbBilgiTel;
        private System.Windows.Forms.Button BtnBilgiEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKisiSil;
        private System.Windows.Forms.Button BtnBilgiGuncelle;
        private System.Windows.Forms.TextBox TbBilgiAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbGuncelleAdi;
        private System.Windows.Forms.TextBox TbGuncelleHobi;
        private System.Windows.Forms.TextBox TbGuncelleTel;
        private System.Windows.Forms.TextBox TbSilAdi;
        private System.Windows.Forms.TextBox TbSilSoyadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox TbBilgiSoyadi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TbGuncelleSoyadi;
        private System.Windows.Forms.Label label12;
    }
}

