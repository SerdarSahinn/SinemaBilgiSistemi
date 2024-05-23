using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _220601006_SERDARŞAHİN_FinalProjesi
{
    public partial class Oyuncular : Form
    {
        private NpgsqlConnection connection;
        private NpgsqlDataAdapter dataAdapter;
        private DataTable filmTable;

        public Oyuncular()
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
            dataAdapter = new NpgsqlDataAdapter($"SELECT oyuncular.gercek_ad, oyuncular.gercek_soyad, COUNT(oduller.oyuncuodul_adı) AS odul_sayisi, filmlerr.film_adı, filmlerr.reyting_sırala, film_turleri.tur_adı, yonetmenler.gercek_ad, yonetmenler.gercek_soyad " +
                                                 "FROM oyuncular " +
                                                 "LEFT JOIN oyuncuveyonetmenler ON oyuncular.oyuncu_id = oyuncuveyonetmenler.oyuncuidsi " +
                                                 "LEFT JOIN filmlerr ON oyuncuveyonetmenler.filmidsi = filmlerr.film_id " +
                                                 "LEFT JOIN filmtureslesme ON filmlerr.film_id = filmtureslesme.filminadı_id " +
                                                 "LEFT JOIN film_turleri ON filmtureslesme.filmtur_id = film_turleri.tur_id " +
                                                 "LEFT JOIN yonetmenler ON oyuncuveyonetmenler.yonetmenidsi = yonetmenler.yonetmen_id " +
                                                 "LEFT JOIN oyuncuid_odulid ON oyuncular.oyuncu_id = oyuncuid_odulid.oyuncu_id " +
                                                 "LEFT JOIN oduller ON oyuncuid_odulid.odul_id = oduller.oyuncuodul_id " +
                                                 "GROUP BY oyuncular.gercek_ad, oyuncular.gercek_soyad, filmlerr.film_adı, filmlerr.reyting_sırala, film_turleri.tur_adı, yonetmenler.gercek_ad, yonetmenler.gercek_soyad", connection);

            filmTable = new DataTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            // TextBox'lardan oyuncu adını ve soyadını al
            string arananOyuncuAdi = oyuncuadtxt.Text;
            string arananOyuncuSoyad = oyuncusoyadtxt.Text;

            using (NpgsqlCommand command = new NpgsqlCommand($"SELECT COUNT(oduller.oyuncuodul_adı) AS odul_sayisi, oyuncular.gercek_ad, oyuncular.gercek_soyad, filmlerr.film_adı, filmlerr.reyting_sırala, film_turleri.tur_adı, yonetmenler.gercek_ad, yonetmenler.gercek_soyad " +
                                                              "FROM oyuncular " +
                                                              "LEFT JOIN oyuncuveyonetmenler ON oyuncular.oyuncu_id = oyuncuveyonetmenler.oyuncuidsi " +
                                                              "LEFT JOIN filmlerr ON oyuncuveyonetmenler.filmidsi = filmlerr.film_id " +
                                                              "LEFT JOIN filmtureslesme ON filmlerr.film_id = filmtureslesme.filminadı_id " +
                                                              "LEFT JOIN film_turleri ON filmtureslesme.filmtur_id = film_turleri.tur_id " +
                                                              "LEFT JOIN yonetmenler ON oyuncuveyonetmenler.yonetmenidsi = yonetmenler.yonetmen_id " +
                                                              "LEFT JOIN oyuncuid_odulid ON oyuncular.oyuncu_id = oyuncuid_odulid.oyuncu_id " +
                                                              "LEFT JOIN oduller ON oyuncuid_odulid.odul_id = oduller.oyuncuodul_id " +
                                                              $"WHERE oyuncular.gercek_ad ILIKE '%{arananOyuncuAdi}%' AND oyuncular.gercek_soyad ILIKE '%{arananOyuncuSoyad}%'" +
                                                              "GROUP BY oyuncular.gercek_ad, oyuncular.gercek_soyad, filmlerr.film_adı, filmlerr.reyting_sırala, film_turleri.tur_adı, yonetmenler.gercek_ad, yonetmenler.gercek_soyad", connection))
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                {
                    DataTable oyuncuFilmlerTable = new DataTable();
                    adapter.Fill(oyuncuFilmlerTable);
                    dataGridView1.DataSource = oyuncuFilmlerTable;
                }
            }
        }
        private void Oyuncular_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }
        private string connectionString = "Host=localhost; Port=5432; Database=postgres; User Id=postgres; Password=12345";
        private void oyuncuilişkileribtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = @"
                            SELECT
                                o1.gercek_ad || ' ' || o1.gercek_soyad AS oyuncu_adi_1,
                                o2.gercek_ad || ' ' || o2.gercek_soyad AS oyuncu_adi_2,
                                ARRAY_AGG(DISTINCT f.film_adı) AS birlikte_oynadiklari_filmler,
                                COUNT(DISTINCT f.film_id) AS birlikte_oynadiklari_film_sayisi
                            FROM
                                oyuncufilm_ilişkisi ofi1
                            JOIN
                                oyuncufilm_ilişkisi ofi2 ON ofi1.film_ide = ofi2.film_ide AND ofi1.oyuncu_id < ofi2.oyuncu_id
                            JOIN
                                oyuncular o1 ON ofi1.oyuncu_id = o1.oyuncu_id
                            JOIN
                                oyuncular o2 ON ofi2.oyuncu_id = o2.oyuncu_id
                            JOIN
                                filmlerr f ON ofi1.film_ide = f.film_id
                            GROUP BY
                                o1.oyuncu_id, o1.gercek_ad, o1.gercek_soyad, o2.oyuncu_id, o2.gercek_ad, o2.gercek_soyad
                            ORDER BY
                                birlikte_oynadiklari_film_sayisi DESC;
                        ";

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void geridonbtn_Click(object sender, EventArgs e)
        {
            Form1 flmm = new Form1();
            flmm.Show();
            this.Hide();

        }
    }
}

