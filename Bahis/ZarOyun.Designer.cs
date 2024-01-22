namespace Bahis
{
    partial class ZarOyun
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZarOyun));
            this.zarAtButon = new System.Windows.Forms.Button();
            this.zar1Image = new System.Windows.Forms.PictureBox();
            this.zar2Image = new System.Windows.Forms.PictureBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bahisMiktar = new System.Windows.Forms.ComboBox();
            this.bahisOran = new System.Windows.Forms.ComboBox();
            this.maxKazanc = new System.Windows.Forms.Label();
            this.Kazanc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toplam = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.puan = new System.Windows.Forms.Label();
            this.lblToplamBakiye = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kayitOl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zar1Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zar2Image)).BeginInit();
            this.SuspendLayout();
            // 
            // zarAtButon
            // 
            this.zarAtButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.zarAtButon.FlatAppearance.BorderSize = 0;
            this.zarAtButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zarAtButon.Font = new System.Drawing.Font("Oswald", 10F);
            this.zarAtButon.Location = new System.Drawing.Point(347, 399);
            this.zarAtButon.Name = "zarAtButon";
            this.zarAtButon.Size = new System.Drawing.Size(153, 70);
            this.zarAtButon.TabIndex = 0;
            this.zarAtButon.Text = "ZAR AT";
            this.zarAtButon.UseVisualStyleBackColor = false;
            this.zarAtButon.Click += new System.EventHandler(this.zarAtButtonClick);
            // 
            // zar1Image
            // 
            this.zar1Image.Location = new System.Drawing.Point(104, 43);
            this.zar1Image.Name = "zar1Image";
            this.zar1Image.Size = new System.Drawing.Size(233, 209);
            this.zar1Image.TabIndex = 1;
            this.zar1Image.TabStop = false;
            // 
            // zar2Image
            // 
            this.zar2Image.Location = new System.Drawing.Point(461, 43);
            this.zar2Image.Name = "zar2Image";
            this.zar2Image.Size = new System.Drawing.Size(233, 209);
            this.zar2Image.TabIndex = 2;
            this.zar2Image.TabStop = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "1.png");
            this.ımageList1.Images.SetKeyName(1, "2 .png");
            this.ımageList1.Images.SetKeyName(2, "3.png");
            this.ımageList1.Images.SetKeyName(3, "4.png");
            this.ımageList1.Images.SetKeyName(4, "5.png");
            this.ımageList1.Images.SetKeyName(5, "6.png");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bahisMiktar
            // 
            this.bahisMiktar.FormattingEnabled = true;
            this.bahisMiktar.Items.AddRange(new object[] {
            "50",
            "100",
            "200",
            "500",
            "1000"});
            this.bahisMiktar.Location = new System.Drawing.Point(16, 305);
            this.bahisMiktar.Name = "bahisMiktar";
            this.bahisMiktar.Size = new System.Drawing.Size(136, 24);
            this.bahisMiktar.TabIndex = 4;
            this.bahisMiktar.SelectedIndexChanged += new System.EventHandler(this.bahisMiktar_SelectedIndexChanged);
            // 
            // bahisOran
            // 
            this.bahisOran.FormattingEnabled = true;
            this.bahisOran.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "7"});
            this.bahisOran.Location = new System.Drawing.Point(184, 306);
            this.bahisOran.Name = "bahisOran";
            this.bahisOran.Size = new System.Drawing.Size(141, 24);
            this.bahisOran.TabIndex = 5;
            this.bahisOran.SelectedIndexChanged += new System.EventHandler(this.bahisOran_SelectedIndexChanged);
            // 
            // maxKazanc
            // 
            this.maxKazanc.AutoSize = true;
            this.maxKazanc.Font = new System.Drawing.Font("Oswald", 10F);
            this.maxKazanc.Location = new System.Drawing.Point(342, 335);
            this.maxKazanc.Name = "maxKazanc";
            this.maxKazanc.Size = new System.Drawing.Size(173, 25);
            this.maxKazanc.TabIndex = 6;
            this.maxKazanc.Text = "KAZANACAĞINIZ MİKTAR";
            // 
            // Kazanc
            // 
            this.Kazanc.AutoSize = true;
            this.Kazanc.Font = new System.Drawing.Font("Oswald", 10F);
            this.Kazanc.ForeColor = System.Drawing.Color.White;
            this.Kazanc.Location = new System.Drawing.Point(538, 334);
            this.Kazanc.Name = "Kazanc";
            this.Kazanc.Size = new System.Drawing.Size(39, 25);
            this.Kazanc.TabIndex = 7;
            this.Kazanc.Text = "000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 10F);
            this.label1.Location = new System.Drawing.Point(26, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bahis Miktarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oswald", 10F);
            this.label2.Location = new System.Drawing.Point(230, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Oran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Oswald", 10F);
            this.label3.Location = new System.Drawing.Point(10, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "SAYILARIN TOPLAMI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Oswald", 10F);
            this.label4.Location = new System.Drawing.Point(189, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "DEN BÜYÜK OLMALIDIR";
            // 
            // toplam
            // 
            this.toplam.AutoSize = true;
            this.toplam.Font = new System.Drawing.Font("Oswald", 14F);
            this.toplam.ForeColor = System.Drawing.Color.Red;
            this.toplam.Location = new System.Drawing.Point(159, 365);
            this.toplam.Name = "toplam";
            this.toplam.Size = new System.Drawing.Size(27, 36);
            this.toplam.TabIndex = 12;
            this.toplam.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Oswald", 10F);
            this.label5.Location = new System.Drawing.Point(616, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "TOPLAM PUAN";
            // 
            // puan
            // 
            this.puan.AutoSize = true;
            this.puan.Font = new System.Drawing.Font("Oswald", 10F);
            this.puan.ForeColor = System.Drawing.Color.White;
            this.puan.Location = new System.Drawing.Point(745, 331);
            this.puan.Name = "puan";
            this.puan.Size = new System.Drawing.Size(30, 25);
            this.puan.TabIndex = 14;
            this.puan.Text = "00";
            // 
            // lblToplamBakiye
            // 
            this.lblToplamBakiye.AutoSize = true;
            this.lblToplamBakiye.Font = new System.Drawing.Font("Oswald", 12F);
            this.lblToplamBakiye.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblToplamBakiye.Location = new System.Drawing.Point(154, 434);
            this.lblToplamBakiye.Name = "lblToplamBakiye";
            this.lblToplamBakiye.Size = new System.Drawing.Size(62, 30);
            this.lblToplamBakiye.TabIndex = 15;
            this.lblToplamBakiye.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Oswald", 10F);
            this.label6.Location = new System.Drawing.Point(26, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "TOPLAM BAKİYE:";
            // 
            // kayitOl
            // 
            this.kayitOl.BackColor = System.Drawing.Color.Transparent;
            this.kayitOl.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.kayitOl.FlatAppearance.BorderSize = 2;
            this.kayitOl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.kayitOl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.kayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayitOl.Font = new System.Drawing.Font("Oswald", 18F);
            this.kayitOl.ForeColor = System.Drawing.Color.Red;
            this.kayitOl.Location = new System.Drawing.Point(759, 12);
            this.kayitOl.Name = "kayitOl";
            this.kayitOl.Size = new System.Drawing.Size(50, 55);
            this.kayitOl.TabIndex = 23;
            this.kayitOl.Text = "X";
            this.kayitOl.UseVisualStyleBackColor = false;
            this.kayitOl.Click += new System.EventHandler(this.kayitOl_Click);
            // 
            // ZarOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(821, 475);
            this.Controls.Add(this.kayitOl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblToplamBakiye);
            this.Controls.Add(this.puan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kazanc);
            this.Controls.Add(this.maxKazanc);
            this.Controls.Add(this.bahisOran);
            this.Controls.Add(this.bahisMiktar);
            this.Controls.Add(this.zar2Image);
            this.Controls.Add(this.zar1Image);
            this.Controls.Add(this.zarAtButon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZarOyun";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.zar1Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zar2Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zarAtButon;
        private System.Windows.Forms.PictureBox zar1Image;
        private System.Windows.Forms.PictureBox zar2Image;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox bahisMiktar;
        private System.Windows.Forms.ComboBox bahisOran;
        private System.Windows.Forms.Label maxKazanc;
        private System.Windows.Forms.Label Kazanc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label toplam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label puan;
        private System.Windows.Forms.Label lblToplamBakiye;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button kayitOl;
    }
}

