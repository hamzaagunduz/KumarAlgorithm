using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Policy;


namespace Bahis
{
    public partial class KayitOl : Form
    {
        private const string connectionString = "Data Source=DESKTOP-O82KITD;Initial Catalog=BahisData;Integrated Security=True";

        public KayitOl()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtAd.Text;
            string sifre = txtSifre.Text;
            string email = txtEmail.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO kullanicilar (kullanici_adi, sifre, email) VALUES (@kullaniciAdi, @sifre, @email)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    command.Parameters.AddWithValue("@sifre", sifre);
                    command.Parameters.AddWithValue("@email", email);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Kayıt başarıyla oluşturuldu.");

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt oluşturulurken bir hata oluştu: " + ex.Message);
            }
        }

        private void girisekran_Click(object sender, EventArgs e)
        {
            GirisForm giris = new GirisForm();
            giris.Show();
            this.Hide();
        }
    }
}
