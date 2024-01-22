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
    public partial class AdminPanel : Form
    {
        public int kullaniciId;
        private const string connectionString = "Data Source=DESKTOP-O82KITD;Initial Catalog=BahisData;Integrated Security=True";
        public  decimal hedefyuzde;
        public decimal result;
        public decimal aktifPara;
        public decimal kazanilanPara;
        public decimal yuzdelikdegkarzarar;
        public AdminPanel()
        {
            InitializeComponent();
            HedefYuzde.Text = GetOransans().ToString();
            hedefyuzde = GetOransans();
            result = GetYuzdeOrani(hedefyuzde);
            label1.Text = result.ToString();
            kazanilanPara = KazanilanParaGet();
            kazanilan.Text = kazanilanPara.ToString();
            sistemkarsans.Text = GetSistemKarSans().ToString();
            aktifPara = GetYuzdeOrani(100);
            aktifp.Text= aktifPara.ToString();

        }

        public void btnGiris_Click(object sender, EventArgs e)
        {
            
            hedefyuzde = decimal.Parse(HedefYuzde.Text);

            UpdateOransans(int.Parse(HedefYuzde.Text));
            result = GetYuzdeOrani(hedefyuzde);
            label1.Text= result.ToString();
            sansduzenle();

        }

        public void sansduzenle()
        {
            int deg1=1;
            int deg2 =3;
            int deg3 = 5;
            int deg4 = 7;
            int deg5 = 9;



            yuzdelikdegkarzarar = KazanlianIstenilenOran(kazanilanPara, result);


            if (yuzdelikdegkarzarar >= 0 && yuzdelikdegkarzarar<=10)
            {
                UpdateSistemKarSans(deg1);
            }
            else if (yuzdelikdegkarzarar > 11 && yuzdelikdegkarzarar < 30)
            {

                UpdateSistemKarSans(deg2);
            }
            else if (yuzdelikdegkarzarar > 31 && yuzdelikdegkarzarar < 50)
            {

                UpdateSistemKarSans(deg3);
            }
            else if (yuzdelikdegkarzarar > 51 && yuzdelikdegkarzarar < 70)
            {

                UpdateSistemKarSans(deg4);
            }
            else if (yuzdelikdegkarzarar > 71 && yuzdelikdegkarzarar < 100)
            {
                UpdateSistemKarSans(deg5);
            }



            sistemkarsans.Text = GetSistemKarSans().ToString();






        }



        public decimal KazanlianIstenilenOran(decimal value1, decimal value2)
        {
            if (value1 == 0|| value2==0)
            {
                // İlk değer sıfır olduğunda sıfır bölme hatasını önlemek için kontrol yapısı
                return 0;
            }

            decimal percentageDifference = (value1 / value2) * 100;

            return percentageDifference;
        }


        public int GetOransans()
        {
            // yüzdekacistedigmiz
            int sans = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT sans FROM BahisData.dbo.oransans", connection);

                connection.Open();
                object value = command.ExecuteScalar();

                if (value != null && int.TryParse(value.ToString(), out int parsedValue))
                {
                    sans = parsedValue;
                }
            }
            return sans;
        }

        public decimal KazanilanParaGet()
        {
            decimal result = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("GetKazanilanPara", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                object value = command.ExecuteScalar();

                if (value != null && decimal.TryParse(value.ToString(), out decimal parsedValue))
                {
                    result = parsedValue;
                }
            }

            return result;
        }


        public void UpdateOransans(int yeniSans)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("UPDATE BahisData.dbo.oransans SET sans = @yeniSans", connection);
                command.Parameters.AddWithValue("@yeniSans", yeniSans);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public decimal GetYuzdeOrani(decimal yuzdelikOran)
        {
            decimal result = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT dbo.GetYuzdeOrani(@yuzdelikOran)", connection);
                command.Parameters.AddWithValue("@yuzdelikOran", yuzdelikOran);

                connection.Open();
                object value = command.ExecuteScalar();

                if (value != null && decimal.TryParse(value.ToString(), out decimal parsedValue))
                {
                    result = parsedValue;
                }
            }

            return result;
        }


        public void UpdateSistemKarSans(decimal yeniDeger)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("UPDATE SistemKarSans SET karsans = @yeniDeger", connection);
                command.Parameters.AddWithValue("@yeniDeger", yeniDeger);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public decimal GetSistemKarSans()
        {
            decimal result = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT karsans FROM SistemKarSans", connection);

                connection.Open();
                object value = command.ExecuteScalar();

                if (value != null && decimal.TryParse(value.ToString(), out decimal parsedValue))
                {
                    result = parsedValue;
                }
            }

            return result;
        }

        private void kayitOl_Click(object sender, EventArgs e)
        {
            GirisForm giris = new GirisForm();
            this.Hide();
            giris.Show();
        }
    }
}
