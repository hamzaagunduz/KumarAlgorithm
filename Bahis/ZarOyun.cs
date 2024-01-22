using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace Bahis
{

   
    public partial class ZarOyun : Form
    {
        private int kullaniciId;
        private const string connectionString = "Data Source=DESKTOP-O82KITD;Initial Catalog=BahisData;Integrated Security=True";

        int maxTemp=0;
        int zar1, zar2;
        float kullanicisansKarZararOraniSans=1f;
        float GetParaFarkiYuzdesiSansFaktordeg =1;

        AdminPanel admin = new AdminPanel();
        public ZarOyun(int kullaniciId)
        {
            InitializeComponent();
            GetToplamBakiye(kullaniciId);

            zar1Image.Image = ımageList1.Images[5];
            zar2Image.Image = ımageList1.Images[5];
            bahisOran.SelectedIndex = 0;

            bahisMiktar.SelectedIndex = 0;

            this.kullaniciId = kullaniciId;

        }


        public void UpdateKazanilanPara(int kullaniciId, decimal kazanilanPara)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("UpdateKazanilanPara", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                command.Parameters.AddWithValue("@kazanilanPara", kazanilanPara);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateKaybedilenPara(int kullaniciId, decimal kaybedilenPara)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("UpdateKaybedilenPara", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                command.Parameters.AddWithValue("@kaybedilenPara", kaybedilenPara);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }






        private decimal GetToplamBakiye(int kullaniciId)
        {
            decimal toplamPara = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT toplam_para FROM bakiye WHERE id = @kullaniciId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        toplamPara = Convert.ToDecimal(result);
                        lblToplamBakiye.Text = toplamPara.ToString();

                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }

            return toplamPara;
        }
        private void zarAtButtonClick(object sender, EventArgs e)
        {
            timer1.Start();
            GetToplamBakiye(kullaniciId);
            admin.btnGiris_Click(sender, e);



        }
        int sayac;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();         
            zar1 = random.Next(0, 6);
            zar2 = random.Next(0, 6);
            zar1Image.Image = ımageList1.Images[zar1];
            zar2Image.Image = ımageList1.Images[zar2];
            sayac++;



            if (sayac == 15)
            {
                
                timer1.Stop();
                sayac= 0;
                float sansfakor=sansHesapla(kullaniciId);
                skor(sansfakor);
            }


        }


        private void skor(float sans)
        {
            Random random = new Random();

            float sonSans = sans;


            if (sonSans >= 0.5 && sonSans < 3)
            {
                zar1 = random.Next(0, 2);
                zar2 = random.Next(0, 1);
             

            }
            else if(sonSans >= 3 && sonSans < 5)
            {
                zar1 = random.Next(0, 3);
                zar2 = random.Next(0, 2);

            }
            else if (sonSans >= 5 && sonSans < 8)
            {
                zar1 = random.Next(1, 2);
                zar2 = random.Next(1, 5);

               
            }
            else if (sonSans >= 8 && sonSans < 10)
            {
                zar1 = random.Next(0, 5);
                zar2 = random.Next(0, 3);

               
            }
            else if (sonSans >= 10 && sonSans < 12)
            {
                zar1 = random.Next(0, 4);
                zar2 = random.Next(0, 5);

            }
            else if (sonSans >= 12 && sonSans < 16)
            {
                zar1 = random.Next(0, 6);
                zar2 = random.Next(0, 4);

             
            }
            else if (sonSans >= 16 && sonSans < 18)
            {
                zar1 = random.Next(0, 5);
                zar2 = random.Next(0, 5);

               
            }
            else if (sonSans >= 18 && sonSans < 22)
            {
                zar1 = random.Next(3, 6);
                zar2 = random.Next(3, 4);

                
            }
            else if (sonSans>=22)
            {
                zar1 = random.Next(5, 6);
                zar2 = random.Next(5, 6);

            }


            zar1Image.Image = ımageList1.Images[zar1];
            zar2Image.Image = ımageList1.Images[zar2];
            int skorTemp = zar1 + zar2 + 2;
            puan.Text = skorTemp.ToString();


            if (Convert.ToInt32(puan.Text) > Convert.ToInt32(toplam.Text))  // kazandıysak
            {
                System.Windows.Forms.MessageBox.Show("Tebrikler Kazandınız");
                UpdateKazanilanPara(kullaniciId, maxTemp);
                ArttirToplamPara(kullaniciId, maxTemp);

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Kaybettiniz");
                UpdateKaybedilenPara(kullaniciId, Convert.ToInt32(bahisMiktar.Text));
                AzaltToplamPara(kullaniciId, Convert.ToInt32(bahisMiktar.Text));

            }




        }


        private float sansHesapla(int kullaniciId)
        {
            this.kullaniciId = kullaniciId;

            int oyunsansfact = GetOransansGame();
            float karzararkullanıcısansoyun = kullaniciKazancKayıbaGoreSansFaktor(kullaniciId);
            float anaParaOrani = GetParaFarkiYuzdesiSansFaktor( kullaniciId);
            float sans = oyunsansfact* karzararkullanıcısansoyun * anaParaOrani;
            

            return sans;
            





        }

        private float GetParaFarkiYuzdesiSansFaktor(int kullaniciId)
        {
            this.kullaniciId = kullaniciId;

            decimal paraorani = GetParaFarkiYuzdesiSans(kullaniciId);

            if (paraorani > 5000)
            {
                GetParaFarkiYuzdesiSansFaktordeg = 1.4f;
            }

            else
                GetParaFarkiYuzdesiSansFaktordeg = 1f;

            return GetParaFarkiYuzdesiSansFaktordeg;

        }




        private float kullaniciKazancKayıbaGoreSansFaktor(int kullaniciId)
        {
            this.kullaniciId = kullaniciId;

            float degkarzarar1 = 3f;   // %50 fazla zarar
            float degkarzarar2 = 2f;   // %50ye kadar zarar
            float degkarzarar3 = 1f;   // ne kar ne zarar
            float degkarzarar4 = 0.7f;   // %50den fazla kar
            float degkarzarar5 = 0.5f;   // %100den fazla kar

            decimal karzararoranikullanici = GetKullaniciKazancKarZararOran(kullaniciId);

            if (karzararoranikullanici <= 0 && karzararoranikullanici >= -50)
            {
                kullanicisansKarZararOraniSans = degkarzarar4;
            }
            else if (karzararoranikullanici < -51 )
            {
                kullanicisansKarZararOraniSans = degkarzarar5;

            }
            else if (karzararoranikullanici > 0 && karzararoranikullanici < 50)
            {
                kullanicisansKarZararOraniSans = degkarzarar3;

            }
            else if (karzararoranikullanici > 51 && karzararoranikullanici < 70)
            {
                kullanicisansKarZararOraniSans = degkarzarar2;

            }
            else if (karzararoranikullanici > 71 )
            {
                kullanicisansKarZararOraniSans = degkarzarar1;

            }

            return kullanicisansKarZararOraniSans;

        }


        public int GetOransansGame()
        {
            // yüzdekacistedigmiz
            int sans = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT karsans FROM SistemKarSans", connection);

                connection.Open();
                object value = command.ExecuteScalar();

                if (value != null && int.TryParse(value.ToString(), out int parsedValue))
                {
                    sans = parsedValue;
                }
            }
            return sans;
        }


        public decimal GetKullaniciKazancKarZararOran(int kullaniciId)
        {
            decimal result = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("GetKullaniciKazancKarZararOran", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                connection.Open();
                object value = command.ExecuteScalar();

                if (value != null && decimal.TryParse(value.ToString(), out decimal parsedValue))
                {
                    result = parsedValue;
                }
            }

            return result;
        }

        public decimal GetParaFarkiYuzdesiSans(int kullaniciId)
        {
            decimal paraFarkiYuzdesi = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT dbo.GetParaFarkiYuzdesiById(@id)", connection);
                command.Parameters.AddWithValue("@id", kullaniciId);

                object value = command.ExecuteScalar();
                if (value != null && decimal.TryParse(value.ToString(), out decimal parsedValue))
                {
                    paraFarkiYuzdesi = parsedValue;
                }
            }

            return paraFarkiYuzdesi;
        }











        public void ArttirToplamPara(int kullaniciId, decimal kazanilanPara)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("ArttirToplamPara", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                command.Parameters.AddWithValue("@kazanilanPara", kazanilanPara);

                connection.Open();
                command.ExecuteNonQuery();
                this.kullaniciId = kullaniciId;

                GetToplamBakiye(kullaniciId);
            }
        }


        public void AzaltToplamPara(int kullaniciId, decimal kaybedilenPara)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("AzaltToplamPara", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                command.Parameters.AddWithValue("@kaybedilenPara", kaybedilenPara);

                connection.Open();
                command.ExecuteNonQuery();
                this.kullaniciId = kullaniciId;

                GetToplamBakiye(kullaniciId);
            }
        }


      
        private void bahisOran_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bahisMiktar.SelectedIndex >= 0)
                {
                   kazancHesap();
                   sayiToplam();
            }
        }

        private void bahisMiktar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                kazancHesap();
                

        }
        private void kazancHesap()
        {
            maxTemp = Convert.ToInt32(bahisMiktar.Text) * Convert.ToInt32(bahisOran.Text);
            Kazanc.Text = maxTemp.ToString();
        }

        private void kayitOl_Click(object sender, EventArgs e)
        {
            KullaniciMenu menudon = new KullaniciMenu(kullaniciId);
            this.Hide();
            menudon.Show();
        }

        private void sayiToplam()
        {     
            if (bahisOran.SelectedIndex == 0)
            {
                int toplamtemp = 5;
                toplam.Text = toplamtemp.ToString();
            }
            else if (bahisOran.SelectedIndex == 1)
            {
                int toplamtemp = 8;
                toplam.Text = toplamtemp.ToString();
            }
            else if (bahisOran.SelectedIndex == 2)
            {
                int toplamtemp = 10;
                toplam.Text = toplamtemp.ToString();
            }
            else if (bahisOran.SelectedIndex == 3)
            {
                int toplamtemp = 11;
                toplam.Text = toplamtemp.ToString();
            }



        }


        




    }
}
