namespace SporKompleksi
{
    partial class FutbolSecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FutbolSecim));
            this.BtnBuyukFutbolSecim = new System.Windows.Forms.Button();
            this.BtnKucukFutbolSecim = new System.Windows.Forms.Button();
            this.BtnFutbolSecimMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBuyukFutbolSecim
            // 
            this.BtnBuyukFutbolSecim.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnBuyukFutbolSecim.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnBuyukFutbolSecim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBuyukFutbolSecim.Location = new System.Drawing.Point(28, 64);
            this.BtnBuyukFutbolSecim.Name = "BtnBuyukFutbolSecim";
            this.BtnBuyukFutbolSecim.Size = new System.Drawing.Size(203, 67);
            this.BtnBuyukFutbolSecim.TabIndex = 0;
            this.BtnBuyukFutbolSecim.Text = "BÜYÜK SAHA";
            this.BtnBuyukFutbolSecim.UseVisualStyleBackColor = false;
            this.BtnBuyukFutbolSecim.Click += new System.EventHandler(this.BtnBuyukFutbolSecim_Click);
            // 
            // BtnKucukFutbolSecim
            // 
            this.BtnKucukFutbolSecim.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnKucukFutbolSecim.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnKucukFutbolSecim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKucukFutbolSecim.Location = new System.Drawing.Point(28, 147);
            this.BtnKucukFutbolSecim.Name = "BtnKucukFutbolSecim";
            this.BtnKucukFutbolSecim.Size = new System.Drawing.Size(203, 68);
            this.BtnKucukFutbolSecim.TabIndex = 1;
            this.BtnKucukFutbolSecim.Text = "KÜÇÜK SAHA";
            this.BtnKucukFutbolSecim.UseVisualStyleBackColor = false;
            this.BtnKucukFutbolSecim.Click += new System.EventHandler(this.BtnKucukFutbolSecim_Click);
            // 
            // BtnFutbolSecimMenu
            // 
            this.BtnFutbolSecimMenu.Location = new System.Drawing.Point(65, 256);
            this.BtnFutbolSecimMenu.Name = "BtnFutbolSecimMenu";
            this.BtnFutbolSecimMenu.Size = new System.Drawing.Size(132, 23);
            this.BtnFutbolSecimMenu.TabIndex = 2;
            this.BtnFutbolSecimMenu.Text = "Seçim Menüsü";
            this.BtnFutbolSecimMenu.UseVisualStyleBackColor = true;
            this.BtnFutbolSecimMenu.Click += new System.EventHandler(this.BtnFutbolSecimMenu_Click);
            // 
            // FutbolSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(259, 280);
            this.Controls.Add(this.BtnFutbolSecimMenu);
            this.Controls.Add(this.BtnKucukFutbolSecim);
            this.Controls.Add(this.BtnBuyukFutbolSecim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FutbolSecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Futbol Sahası Seçim";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBuyukFutbolSecim;
        private System.Windows.Forms.Button BtnKucukFutbolSecim;
        private System.Windows.Forms.Button BtnFutbolSecimMenu;
    }
}