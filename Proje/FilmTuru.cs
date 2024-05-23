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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _220601006_SERDARŞAHİN_FinalProjesi
{
    public partial class FilmTuru : Form
    {

        private NpgsqlConnection connection;
        private NpgsqlDataAdapter dataAdapter;
        private DataTable filmTable;

        public FilmTuru()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadData();
        }
        private void InitializeDatabase()
        {
            string connectionString = "Host=localhost; Port=5432; Database=postgres; User Id=postgres; Password=12345";

            connection = new NpgsqlConnection(connectionString);

            dataAdapter = new NpgsqlDataAdapter("SELECT filmlerr.film_adı, filmlerr.reyting_sırala, film_turleri.tur_adı, oyuncular.gercek_ad, oyuncular.gercek_soyad, yonetmenler.gercek_ad, yonetmenler.gercek_soyad " +
                                                 "FROM filmlerr " +
                                                 "JOIN filmtureslesme ON filmlerr.film_id = filmtureslesme.filminadı_id " +
                                                 "JOIN film_turleri ON filmtureslesme.filmtur_id = film_turleri.tur_id " +
                                                 "LEFT JOIN oyuncuveyonetmenler ON filmlerr.film_id = oyuncuveyonetmenler.filmidsi " +
                                                 "LEFT JOIN oyuncular ON oyuncuveyonetmenler.oyuncuidsi = oyuncular.oyuncu_id " +
                                                 "LEFT JOIN yonetmenler ON oyuncuveyonetmenler.yonetmenidsi = yonetmenler.yonetmen_id", connection);

            filmTable = new DataTable();
        }
        private void LoadData()
        {
            dataAdapter.Fill(filmTable);
            dataGridView1.DataSource = filmTable;
        }
        private void tureslesmebtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            string arananTur = Turadıtxt.Text;

            using (NpgsqlCommand command = new NpgsqlCommand("SELECT filmlerr.reyting_sırala, filmlerr.film_adı,oyuncular.gercek_ad, oyuncular.gercek_soyad, yonetmenler.gercek_ad, yonetmenler.gercek_soyad " +
                                                             "FROM oyuncuveyonetmenler " +
                                                             "LEFT JOIN oyuncular ON oyuncuveyonetmenler.oyuncuidsi = oyuncular.oyuncu_id " +
                                                             "LEFT JOIN filmlerr ON oyuncuveyonetmenler.filmidsi = filmlerr.film_id " +
                                                             "LEFT JOIN yonetmenler ON oyuncuveyonetmenler.yonetmenidsi = yonetmenler.yonetmen_id " +
                                                             "LEFT JOIN filmtureslesme ON filmlerr.film_id = filmtureslesme.filminadı_id " +
                                                             "LEFT JOIN film_turleri ON filmtureslesme.filmtur_id = film_turleri.tur_id " +
                                                             $"WHERE film_turleri.tur_adı ILIKE '%{arananTur}%' " +
                                                             "ORDER BY filmlerr.reyting_sırala DESC", connection))
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                {
                    DataTable filteredTable = new DataTable();
                    adapter.Fill(filteredTable);
                    dataGridView1.DataSource = filteredTable;
                }
            }
        }

        private void FilmTuru_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void geridonbtn_Click(object sender, EventArgs e)
        {
            Filmer ff = new Filmer();
            ff.Show();
            this.Hide();
        }
    }
}
