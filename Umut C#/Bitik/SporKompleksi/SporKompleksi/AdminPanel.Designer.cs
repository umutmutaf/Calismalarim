namespace SporKompleksi
{
    partial class AdminPanel
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
            this.BtnGirisSayfasi = new System.Windows.Forms.Button();
            this.BtnAdminSil = new System.Windows.Forms.Button();
            this.LstViewRezervListe = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "REZERVASYON LİSTESİ";
            // 
            // BtnGirisSayfasi
            // 
            this.BtnGirisSayfasi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGirisSayfasi.Location = new System.Drawing.Point(12, 281);
            this.BtnGirisSayfasi.Name = "BtnGirisSayfasi";
            this.BtnGirisSayfasi.Size = new System.Drawing.Size(193, 36);
            this.BtnGirisSayfasi.TabIndex = 2;
            this.BtnGirisSayfasi.Text = "Giriş Menüsü";
            this.BtnGirisSayfasi.UseVisualStyleBackColor = true;
            this.BtnGirisSayfasi.Click += new System.EventHandler(this.BtnGirisSayfasi_Click);
            // 
            // BtnAdminSil
            // 
            this.BtnAdminSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdminSil.Location = new System.Drawing.Point(531, 281);
            this.BtnAdminSil.Name = "BtnAdminSil";
            this.BtnAdminSil.Size = new System.Drawing.Size(93, 36);
            this.BtnAdminSil.TabIndex = 3;
            this.BtnAdminSil.Text = "Sil";
            this.BtnAdminSil.UseVisualStyleBackColor = true;
            this.BtnAdminSil.Click += new System.EventHandler(this.BtnAdminSil_Click);
            // 
            // LstViewRezervListe
            // 
            this.LstViewRezervListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LstViewRezervListe.FullRowSelect = true;
            this.LstViewRezervListe.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LstViewRezervListe.LabelWrap = false;
            this.LstViewRezervListe.Location = new System.Drawing.Point(12, 68);
            this.LstViewRezervListe.Name = "LstViewRezervListe";
            this.LstViewRezervListe.Size = new System.Drawing.Size(612, 207);
            this.LstViewRezervListe.TabIndex = 4;
            this.LstViewRezervListe.UseCompatibleStateImageBehavior = false;
            this.LstViewRezervListe.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tarih";
            this.columnHeader2.Width = 104;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Saat";
            this.columnHeader3.Width = 72;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Saha Adı";
            this.columnHeader4.Width = 171;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.Width = 154;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SporKompleksi.Properties.Resources.arka;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 329);
            this.Controls.Add(this.LstViewRezervListe);
            this.Controls.Add(this.BtnAdminSil);
            this.Controls.Add(this.BtnGirisSayfasi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGirisSayfasi;
        private System.Windows.Forms.Button BtnAdminSil;
        private System.Windows.Forms.ListView LstViewRezervListe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}