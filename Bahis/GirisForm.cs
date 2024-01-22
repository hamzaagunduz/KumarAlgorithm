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
    public partial class GirisForm : Form
    {
        private const string connectionString = "Data Source=DESKTOP-O82KITD;Initial Catalog=BahisData;Integrated Security=True";
        int kullaniciId = 0;
        public GirisForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM kullanicilar WHERE kullanici_adi = @kullaniciAdi AND sifre = @sifre";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    command.Parameters.AddWithValue("@sifre", sifre);

                    int userCount = (int)command.ExecuteScalar();

                    if (userCount > 0)
                    {

                        MessageBox.Show("Giriş başarılı.");
                        GetKullaniciId(kullaniciAdi);
                        KullaniciMenu menu= new KullaniciMenu(kullaniciId);

                        menu.Show();
                        this.Hide();

                       
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş yapılırken bir hata oluştu: " + ex.Message);
            }
        }

        private int GetKullaniciId(string kullaniciAdi)
        {
            

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id FROM kullanicilar WHERE kullanici_adi = @kullaniciAdi";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        kullaniciId = (int)result;
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı kimliği alınırken bir hata oluştu: " + ex.Message);
            }

            return kullaniciId;
        }





        private void kayitOl_Click(object sender, EventArgs e)
        {
            KayitOl kayit =new KayitOl();
            kayit.Show();
            this.Hide();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            this.Hide();
            admin.Show();
        }
    }
}
