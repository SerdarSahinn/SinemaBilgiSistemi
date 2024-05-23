using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _220601006_SERDARŞAHİN_FinalProjesi
{
    public partial class filmÖzelikleri : Form
    {
        private NpgsqlConnection connection;
        private NpgsqlDataAdapter dataAdapter;
        private DataTable filmTable;
        public filmÖzelikleri()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadData();
        }
        private void LoadData()
        {
            dataAdapter.Fill(filmTable);
            dataGridView1.DataSource = filmTable;
        }
        private void InitializeDatabase()
        {
            string connectionString = "Host=localhost; Port=5432; Database=postgres; User Id=postgres; Password=12345";
            connection = new NpgsqlConnection(connectionString);

            // SQL sorgusunu TextBox'lardan alacak şekilde düzenleme
            dataAdapter = new NpgsqlDataAdapter($"SELECT * from filmlerr", connection);

            filmTable = new DataTable();
        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            // TextBox'lardan oyuncu adını ve soyadını al
            string arananOyuncuAdi = Filmadıtxt.Text;


            using (NpgsqlCommand command = new NpgsqlCommand($"SELECT * from filmlerr WHERE film_adı ILIKE '%{arananOyuncuAdi}%'", connection))
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                {
                    DataTable oyuncuFilmlerTable = new DataTable();
                    adapter.Fill(oyuncuFilmlerTable);
                    dataGridView1.DataSource = oyuncuFilmlerTable;
                }
            }
        }



        NpgsqlConnection baglan = new NpgsqlConnection("Server = localhost; port=5432; Database=postgres;user Id = postgres; password=12345");
        public void verilerigoster(string txt)
        {
            baglan.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = baglan;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader rd = komut.ExecuteReader();
            if (rd.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(rd);
                dataGridView1.DataSource = dt;
            }
            komut.Dispose();
            baglan.Close();
        }


        private void filmeklebtn_Click(object sender, EventArgs e)
        {
            eklegroupbox.Visible = true;
            Silfroupbox.Visible = false;
            guncellegorupbox.Visible = false;

        }

        private void filmieklebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }

                // Tarih değerini doğru formatta parse ediyoruz.
                DateTime yapimYili;
                if (!DateTime.TryParseExact(yapımyılıtxt.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out yapimYili))
                {
                    MessageBox.Show("Geçersiz tarih formatı!");
                    return;
                }

                NpgsqlCommand komut_ekle = new NpgsqlCommand();
                komut_ekle.Connection = baglan;

                komut_ekle.Parameters.AddWithValue("@filmadı", NpgsqlDbType.Varchar).Value = adtxt.Text;
                komut_ekle.Parameters.AddWithValue("@reyting", NpgsqlDbType.Numeric).Value = decimal.Parse(reytingtxt.Text);
                komut_ekle.Parameters.AddWithValue("@butcem", NpgsqlDbType.Numeric).Value = decimal.Parse(butcetxt.Text);
                komut_ekle.Parameters.AddWithValue("@yapımyılı", NpgsqlDbType.Date).Value = yapimYili;
                komut_ekle.Parameters.AddWithValue("@gise", NpgsqlDbType.Numeric).Value = decimal.Parse(gisetxt.Text);

                komut_ekle.CommandType = CommandType.Text;
                komut_ekle.CommandText = "INSERT INTO filmlerr (film_adı, reyting_sırala, butce, yapım_yılı, gise_sayısı) VALUES (@filmadı, @reyting, @butcem, @yapımyılı, @gise)";

                int affectedRows = komut_ekle.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    // Eğer etkilenen satır varsa işlemlerinizi gerçekleştirin.
                    MessageBox.Show("Film Ekleme İşlemi Başarılı Bir Şekilde Gerçekleşti");
                    verilerigoster("SELECT * FROM filmlerr");
                }
                else
                {
                    MessageBox.Show("Film Ekleme İşlemi Başarısız!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
            }
        }

        private void filmisilbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }

                int filmIdToDelete = int.Parse(limsiltxt.Text); // Silinecek film_id'yi alın

                NpgsqlCommand komut_sil = new NpgsqlCommand();
                komut_sil.Connection = baglan;

                komut_sil.Parameters.AddWithValue("@filmId", NpgsqlDbType.Integer).Value = filmIdToDelete;

                komut_sil.CommandType = CommandType.Text;
                komut_sil.CommandText = "DELETE FROM filmlerr WHERE film_id = @filmId";

                int affectedRows = komut_sil.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    // Eğer etkilenen satır varsa işlemlerinizi gerçekleştirin.
                    MessageBox.Show("Film Silme İşlemi Başarılı Bir Şekilde Gerçekleşti");
                    verilerigoster("SELECT * FROM filmlerr");
                }
                else
                {
                    MessageBox.Show("Belirtilen film_id ile eşleşen film bulunamadı!");
                }
            }
            catch (Exception ex)
            {
                //  MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
            }
        }



        private void FilmBilgileriniGetir(int filmId)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }

                NpgsqlCommand komut_getir = new NpgsqlCommand();
                komut_getir.Connection = baglan;

                komut_getir.Parameters.AddWithValue("@filmId", NpgsqlDbType.Integer).Value = filmId;

                komut_getir.CommandType = CommandType.Text;
                komut_getir.CommandText = "SELECT film_id, film_adı, reyting_sırala, butce, yapım_yılı, gise_sayısı FROM filmlerr WHERE film_id = @filmId";

                NpgsqlDataReader dr = komut_getir.ExecuteReader();

                if (dr.Read())
                {
                    // TextBox'lara veritabanından gelen değerleri yaz
                    guncelleidtxt.Text = dr["film_id"].ToString();
                    guncelleadtxt.Text = dr["film_adı"].ToString();
                    guncellereytingtxt.Text = dr["reyting_sırala"].ToString();
                    guncellebutcetxt.Text = dr["butce"].ToString();
                    guncelleyıltxt.Text = dr["yapım_yılı"].ToString();
                    guncellegisetxt.Text = dr["gise_sayısı"].ToString();
                }
                else
                {
                    MessageBox.Show("Belirtilen film_id ile eşleşen film bulunamadı!");
                }
            }
            catch (Exception ex)
            {
                //  MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
            }
        }


        private void Filmigetirbtn_Click(object sender, EventArgs e)
        {
            int filmId;
            if (int.TryParse(filmigetirtxt.Text, out filmId))
            {
                FilmBilgileriniGetir(filmId);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir film_id girin.");
            }
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            int filmId = int.Parse(guncelleidtxt.Text);

            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }

                NpgsqlCommand komut_guncelle = new NpgsqlCommand();
                komut_guncelle.Connection = baglan;

                komut_guncelle.Parameters.AddWithValue("@filmId", NpgsqlDbType.Integer).Value = filmId;
                komut_guncelle.Parameters.AddWithValue("@filmAdi", NpgsqlDbType.Varchar).Value = guncelleadtxt.Text;
                komut_guncelle.Parameters.AddWithValue("@reyting", NpgsqlDbType.Numeric).Value = decimal.Parse(guncellereytingtxt.Text);
                komut_guncelle.Parameters.AddWithValue("@butce", NpgsqlDbType.Numeric).Value = decimal.Parse(guncellebutcetxt.Text);
                komut_guncelle.Parameters.AddWithValue("@yapimYili", NpgsqlDbType.Date).Value = DateTime.ParseExact(guncelleyıltxt.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                komut_guncelle.Parameters.AddWithValue("@giseSayisi", NpgsqlDbType.Numeric).Value = decimal.Parse(guncellegisetxt.Text);

                komut_guncelle.CommandType = CommandType.Text;
                komut_guncelle.CommandText = "UPDATE filmlerr SET film_adı = @filmAdi, reyting_sırala = @reyting, butce = @butce, yapım_yılı = @yapimYili, gise_sayısı = @giseSayisi WHERE film_id = @filmId";

                int affectedRows = komut_guncelle.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Film Güncelleme İşlemi Başarılı Bir Şekilde Gerçekleşti");
                    verilerigoster("SELECT * FROM filmlerr");
                }
                else
                {
                    MessageBox.Show("Belirtilen film_id ile eşleşen film bulunamadı!");
                }
            }
            catch (Exception ex)
            {
                //   MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
            }
        }

        private void filmsilbtn_Click(object sender, EventArgs e)
        {
            Silfroupbox.Visible = true;
            eklegroupbox.Visible = false;
            guncellegorupbox.Visible = false;
        }

        private void filguncellebtn_Click(object sender, EventArgs e)
        {
            guncellegorupbox.Visible = true;
            eklegroupbox.Visible = false;
            Silfroupbox.Visible = false;
        }

        private void filmÖzelikleri_Load(object sender, EventArgs e)
        {
            guncellegorupbox.Visible = false;
            Silfroupbox.Visible = false;
            eklegroupbox.Visible = false;
        }

        private void geridonbtn_Click(object sender, EventArgs e)
        {
            Filmer f = new Filmer();
            f.Show();
            this.Hide();
        }
    }
}
