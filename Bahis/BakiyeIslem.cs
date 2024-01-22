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
    public partial class BakiyeIslem : Form
    {
        private const string connectionString = "Data Source=DESKTOP-O82KITD;Initial Catalog=BahisData;Integrated Security=True";

        private int kullaniciId;
        AdminPanel admin = new AdminPanel();

        public BakiyeIslem(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
            GetKullaniciAdi(kullaniciId);
            GetToplamBakiye(kullaniciId);
        }

        private void BtnParaYatir_Click(object sender, EventArgs e)
        {
            decimal yatirilanMiktar = decimal.Parse(txtYatirilanMiktar.Text);
            // Para yatırma işlemini gerçekleştirmek için ParaYatir fonksiyonunu çağır
            ParaYatir(kullaniciId, yatirilanMiktar);
            GetToplamBakiye(kullaniciId);
            admin.btnGiris_Click(sender, e);

        }

        // Para yatırma işlemini gerçekleştiren fonksiyon
        private void ParaYatir(int kullaniciId, decimal yatirilanMiktar)
        {
            try
            {
                // SQL bağlantısı ve sorgu oluşturma
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "EXEC ParaYatir @kullaniciId, @yatirilanMiktar";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                    command.Parameters.AddWithValue("@yatirilanMiktar", yatirilanMiktar);

                    command.ExecuteNonQuery();
                    UpdateToplamPara(connection, kullaniciId);
                    MessageBox.Show("Para yatırma işlemi başarılı.");

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void ParaCek(int kullaniciId, decimal cekilenMiktar)
        {
            try
            {
                // SQL bağlantısı ve sorgu oluşturma
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "EXEC ParaCek @kullaniciId, @cekilenMiktar";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                    command.Parameters.AddWithValue("@cekilenMiktar", cekilenMiktar);

                    command.ExecuteNonQuery();
                    UpdateToplamPara(connection, kullaniciId);
                    MessageBox.Show("Para çekme işlemi başarılı.");

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
        private void BtnParaCek_Click(object sender, EventArgs e)
        {
            decimal cekilenMiktar = decimal.Parse(txtCekilenMiktar.Text);

            // Para yatırma işlemini gerçekleştirmek için ParaYatir fonksiyonunu çağır
            ParaCek(kullaniciId, cekilenMiktar);
            GetToplamBakiye(kullaniciId);
            admin.btnGiris_Click(sender, e);

        }


        private void UpdateToplamPara(SqlConnection connection, int kullaniciId)
        {
            string updateQuery = @"
        UPDATE bakiye
        SET toplam_para = ISNULL((SELECT SUM(yatirilan_para) FROM bakiye WHERE id = @kullaniciId), 0)
                        - ISNULL((SELECT SUM(cekilen_para) FROM bakiye WHERE id = @kullaniciId), 0)
        WHERE id = @kullaniciId";

            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@kullaniciId", kullaniciId);

            updateCommand.ExecuteNonQuery();
        }


        // Giriş işlemi başarılı olduğunda çağrılacak fonksiyon
       private string GetKullaniciAdi(int kullaniciId)
{
    try
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT kullanici_adi FROM kullanicilar WHERE id = @kullaniciId";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@kullaniciId", kullaniciId);

            string kullaniciAdi = command.ExecuteScalar()?.ToString();

            connection.Close();
            lblKullaniciAdi.Text = kullaniciAdi;
            return kullaniciAdi;
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Hata oluştu: " + ex.Message);
        return null;
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

        private void kayitOl_Click(object sender, EventArgs e)
        {
            KullaniciMenu menudon = new KullaniciMenu(kullaniciId);
            this.Hide();
            menudon.Show();
        }
    }





}

