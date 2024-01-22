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
    public partial class SifreDegis : Form
    {
        private const string connectionString = "Data Source=DESKTOP-O82KITD;Initial Catalog=BahisData;Integrated Security=True";
        private int kullaniciId;
        public SifreDegis(int kullaniciId)
        {
            this.kullaniciId = kullaniciId;

            InitializeComponent();
        }

        private void BtnSifreGuncelle_Click(object sender, EventArgs e)
        {
            string eskiSifre = txtEskiSifre.Text;
            string yeniSifre = txtYeniSifre.Text;




            // Şifreyi güncelleme işlemini gerçekleştirmek için SifreGuncelle fonksiyonunu çağır
            SifreGuncelle(kullaniciId, eskiSifre, yeniSifre);
        }

        private void SifreGuncelle(int kullaniciId, string eskiSifre, string yeniSifre)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SifreGuncelle", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                    command.Parameters.AddWithValue("@eskiSifre", eskiSifre);
                    command.Parameters.AddWithValue("@yeniSifre", yeniSifre);
                    command.Parameters.Add("@result", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;

                    command.ExecuteNonQuery();

                    string result = command.Parameters["@result"].Value.ToString();
                    MessageBox.Show(result);

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void kayitOl_Click(object sender, EventArgs e)
        {
            KullaniciMenu menudon = new KullaniciMenu(kullaniciId);
            this.Hide();
            menudon.Show();
        }
    }
}
