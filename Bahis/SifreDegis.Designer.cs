namespace Bahis
{
    partial class SifreDegis
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
            this.txtEskiSifre = new System.Windows.Forms.TextBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.girisekran = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kayitOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEskiSifre
            // 
            this.txtEskiSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEskiSifre.Font = new System.Drawing.Font("Palatino Linotype", 19.8F);
            this.txtEskiSifre.Location = new System.Drawing.Point(106, 118);
            this.txtEskiSifre.Name = "txtEskiSifre";
            this.txtEskiSifre.Size = new System.Drawing.Size(308, 45);
            this.txtEskiSifre.TabIndex = 3;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYeniSifre.Font = new System.Drawing.Font("Palatino Linotype", 19.8F);
            this.txtYeniSifre.Location = new System.Drawing.Point(106, 250);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(308, 45);
            this.txtYeniSifre.TabIndex = 4;
            // 
            // girisekran
            // 
            this.girisekran.BackColor = System.Drawing.Color.White;
            this.girisekran.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisekran.Location = new System.Drawing.Point(190, 329);
            this.girisekran.Name = "girisekran";
            this.girisekran.Size = new System.Drawing.Size(142, 48);
            this.girisekran.TabIndex = 9;
            this.girisekran.Text = "SİFRE DEĞİŞTİR";
            this.girisekran.UseVisualStyleBackColor = false;
            this.girisekran.Click += new System.EventHandler(this.BtnSifreGuncelle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 45);
            this.label3.TabIndex = 11;
            this.label3.Text = "ESKİ ŞİFRENİZİ GİRİNİZ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 45);
            this.label1.TabIndex = 12;
            this.label1.Text = "YENİ ŞİFRENİZİ GİRİNİZ";
            // 
            // kayitOl
            // 
            this.kayitOl.BackColor = System.Drawing.Color.Transparent;
            this.kayitOl.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.kayitOl.FlatAppearance.BorderSize = 2;
            this.kayitOl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.kayitOl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.kayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayitOl.Font = new System.Drawing.Font("Oswald", 11F);
            this.kayitOl.ForeColor = System.Drawing.Color.Red;
            this.kayitOl.Location = new System.Drawing.Point(482, 12);
            this.kayitOl.Name = "kayitOl";
            this.kayitOl.Size = new System.Drawing.Size(32, 41);
            this.kayitOl.TabIndex = 22;
            this.kayitOl.Text = "X";
            this.kayitOl.UseVisualStyleBackColor = false;
            this.kayitOl.Click += new System.EventHandler(this.kayitOl_Click);
            // 
            // SifreDegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Bahis.Properties.Resources.pexels_mahadee_hasan_15849321;
            this.ClientSize = new System.Drawing.Size(526, 419);
            this.Controls.Add(this.kayitOl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.girisekran);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.txtEskiSifre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SifreDegis";
            this.Text = "SifreDegis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEskiSifre;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Button girisekran;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kayitOl;
    }
}