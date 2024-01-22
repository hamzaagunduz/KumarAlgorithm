using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bahis
{
    public partial class KullaniciMenu : Form
    {
        public int kullaniciId;

        public KullaniciMenu(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BakiyeIslem bakiye = new BakiyeIslem(kullaniciId);

            bakiye.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SifreDegis sifreGuncelleme = new SifreDegis(kullaniciId);
            sifreGuncelleme.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZarOyun oyun =new ZarOyun(kullaniciId);
            oyun.Show();
            this.Hide();
        }

        private void kayitOl_Click(object sender, EventArgs e)
        {
            GirisForm giris = new GirisForm();
            giris.Show();
            this.Hide();
        }
    }
}
