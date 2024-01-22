namespace Bahis
{
    partial class GirisForm
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
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kayitOl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Palatino Linotype", 19.8F);
            this.txtKullaniciAdi.Location = new System.Drawing.Point(253, 177);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(297, 45);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Palatino Linotype", 19.8F);
            this.txtSifre.Location = new System.Drawing.Point(253, 242);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(297, 45);
            this.txtSifre.TabIndex = 1;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGiris.FlatAppearance.BorderSize = 2;
            this.btnGiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Oswald", 9F);
            this.btnGiris.ForeColor = System.Drawing.Color.Transparent;
            this.btnGiris.Location = new System.Drawing.Point(274, 319);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(119, 40);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre";
            // 
            // kayitOl
            // 
            this.kayitOl.BackColor = System.Drawing.Color.Transparent;
            this.kayitOl.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.kayitOl.FlatAppearance.BorderSize = 2;
            this.kayitOl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.kayitOl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.kayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayitOl.Font = new System.Drawing.Font("Oswald", 9F);
            this.kayitOl.ForeColor = System.Drawing.Color.Transparent;
            this.kayitOl.Location = new System.Drawing.Point(407, 319);
            this.kayitOl.Name = "kayitOl";
            this.kayitOl.Size = new System.Drawing.Size(119, 40);
            this.kayitOl.TabIndex = 6;
            this.kayitOl.Text = "KAYİT OL";
            this.kayitOl.UseVisualStyleBackColor = false;
            this.kayitOl.Click += new System.EventHandler(this.kayitOl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(683, 56);
            this.label3.TabIndex = 7;
            this.label3.Text = "VIRTUAL BETTING ALGORITHM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(102, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(582, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(290, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "It is a long established  V12";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.Color.Transparent;
            this.admin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.admin.FlatAppearance.BorderSize = 2;
            this.admin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin.Font = new System.Drawing.Font("Oswald", 9F);
            this.admin.ForeColor = System.Drawing.Color.Transparent;
            this.admin.Location = new System.Drawing.Point(696, 425);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(119, 40);
            this.admin.TabIndex = 10;
            this.admin.Text = "ADMİN";
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bahis.Properties.Resources.pexels_mahadee_hasan_15849018;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 471);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kayitOl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisForm";
            this.Text = "GirisForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kayitOl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button admin;
    }
}