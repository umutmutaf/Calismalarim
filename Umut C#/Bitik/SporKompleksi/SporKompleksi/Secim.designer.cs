namespace SporKompleksi
{
    partial class Secim
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
            this.BtnSecimFutbol = new System.Windows.Forms.Button();
            this.BtnSecimBasketbol = new System.Windows.Forms.Button();
            this.BtnSecimVoleybol = new System.Windows.Forms.Button();
            this.BtnSecimMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSecimFutbol
            // 
            this.BtnSecimFutbol.BackColor = System.Drawing.Color.Transparent;
            this.BtnSecimFutbol.BackgroundImage = global::SporKompleksi.Properties.Resources.futbol2;
            this.BtnSecimFutbol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSecimFutbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSecimFutbol.ForeColor = System.Drawing.Color.White;
            this.BtnSecimFutbol.Location = new System.Drawing.Point(33, 22);
            this.BtnSecimFutbol.Name = "BtnSecimFutbol";
            this.BtnSecimFutbol.Size = new System.Drawing.Size(125, 108);
            this.BtnSecimFutbol.TabIndex = 0;
            this.BtnSecimFutbol.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSecimFutbol.UseVisualStyleBackColor = false;
            this.BtnSecimFutbol.Click += new System.EventHandler(this.BtnSecimFutbol_Click);
            this.BtnSecimFutbol.MouseLeave += new System.EventHandler(this.BtnSecimFutbol_MouseLeave);
            this.BtnSecimFutbol.MouseHover += new System.EventHandler(this.BtnSecimFutbol_MouseHover);
            // 
            // BtnSecimBasketbol
            // 
            this.BtnSecimBasketbol.BackColor = System.Drawing.Color.Transparent;
            this.BtnSecimBasketbol.BackgroundImage = global::SporKompleksi.Properties.Resources.basketbol2;
            this.BtnSecimBasketbol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSecimBasketbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSecimBasketbol.ForeColor = System.Drawing.Color.White;
            this.BtnSecimBasketbol.Location = new System.Drawing.Point(200, 22);
            this.BtnSecimBasketbol.Name = "BtnSecimBasketbol";
            this.BtnSecimBasketbol.Size = new System.Drawing.Size(125, 108);
            this.BtnSecimBasketbol.TabIndex = 1;
            this.BtnSecimBasketbol.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSecimBasketbol.UseVisualStyleBackColor = false;
            this.BtnSecimBasketbol.Click += new System.EventHandler(this.BtnSecimBasketbol_Click);
            this.BtnSecimBasketbol.MouseLeave += new System.EventHandler(this.BtnSecimBasketbol_MouseLeave);
            this.BtnSecimBasketbol.MouseHover += new System.EventHandler(this.BtnSecimBasketbol_MouseHover);
            // 
            // BtnSecimVoleybol
            // 
            this.BtnSecimVoleybol.BackgroundImage = global::SporKompleksi.Properties.Resources.voleybol2;
            this.BtnSecimVoleybol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSecimVoleybol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSecimVoleybol.ForeColor = System.Drawing.Color.White;
            this.BtnSecimVoleybol.Location = new System.Drawing.Point(367, 22);
            this.BtnSecimVoleybol.Name = "BtnSecimVoleybol";
            this.BtnSecimVoleybol.Size = new System.Drawing.Size(125, 108);
            this.BtnSecimVoleybol.TabIndex = 2;
            this.BtnSecimVoleybol.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSecimVoleybol.UseVisualStyleBackColor = true;
            this.BtnSecimVoleybol.Click += new System.EventHandler(this.BtnSecimVoleybol_Click);
            this.BtnSecimVoleybol.MouseLeave += new System.EventHandler(this.BtnSecimVoleybol_MouseLeave);
            this.BtnSecimVoleybol.MouseHover += new System.EventHandler(this.BtnSecimVoleybol_MouseHover);
            // 
            // BtnSecimMenu
            // 
            this.BtnSecimMenu.BackColor = System.Drawing.Color.Maroon;
            this.BtnSecimMenu.ForeColor = System.Drawing.Color.White;
            this.BtnSecimMenu.Location = new System.Drawing.Point(211, 155);
            this.BtnSecimMenu.Name = "BtnSecimMenu";
            this.BtnSecimMenu.Size = new System.Drawing.Size(101, 48);
            this.BtnSecimMenu.TabIndex = 3;
            this.BtnSecimMenu.Text = "Girişe Menüsü";
            this.BtnSecimMenu.UseVisualStyleBackColor = false;
            this.BtnSecimMenu.Click += new System.EventHandler(this.BtnSecimMenu_Click);
            // 
            // Secim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SporKompleksi.Properties.Resources.arka1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(531, 215);
            this.Controls.Add(this.BtnSecimMenu);
            this.Controls.Add(this.BtnSecimVoleybol);
            this.Controls.Add(this.BtnSecimBasketbol);
            this.Controls.Add(this.BtnSecimFutbol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Secim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seçim Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSecimFutbol;
        private System.Windows.Forms.Button BtnSecimBasketbol;
        private System.Windows.Forms.Button BtnSecimVoleybol;
        private System.Windows.Forms.Button BtnSecimMenu;
    }
}