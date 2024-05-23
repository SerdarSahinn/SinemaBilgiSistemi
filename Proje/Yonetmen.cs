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
    public partial class Yonetmen : Form
    {
        private NpgsqlConnection connection;

        public Yonetmen()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            string connectionString = "Host=localhost; Port=5432; Database=postgres; User Id=postgres; Password=12345";
            connection = new NpgsqlConnection(connectionString);
        }

        private void listelebtn_Click(object sender, EventArgs e)
        {

            dataGridView1.Visible = true;

            string arananYonetmenAdi = Aratxt.Text;
            string arananYonetmenSoyad = soyadtxt.Text;

            using (NpgsqlCommand command = new NpgsqlCommand("SELECT " +
                                                             "    yonetmenler.gercek_ad AS \"Yönetmen Adı\", " +
                                                             "    yonetmenler.gercek_soyad AS \"Yönetmen Soyadı\", " +
                                                             "    filmlerr.film_adı AS \"Çektiği Film\", " +
                                                             "    yonetmen_oduler.yonetmenodul_adı AS \"Aldığı Ödül Adı\" " +
                                                             "FROM " +
                                                             "    yonetmenlerioduller_goster " +
                                                             "JOIN " +
                                                             "    yonetmenler ON yonetmenler.yonetmen_id = yonetmenlerioduller_goster.yonetmen_idleri " +
                                                             "JOIN " +
                                                             "    filmlerr ON filmlerr.film_id = yonetmenlerioduller_goster.filmidsi " +
                                                             "JOIN " +
                                                             "    yonetmen_oduler ON yonetmen_oduler.yonetmenodul_id = yonetmenlerioduller_goster.yonetmenodul_adları " +
                                                             $"WHERE yonetmenler.gercek_ad ILIKE '%{arananYonetmenAdi}%' AND yonetmenler.gercek_soyad ILIKE '%{arananYonetmenSoyad}%'", connection))
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                {
                    DataTable yonetmenFilmlerTable = new DataTable();
                    adapter.Fill(yonetmenFilmlerTable);
                    dataGridView1.DataSource = yonetmenFilmlerTable;
                }
            }
        }

        private void Yonetmen_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void geridonbtn_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();

        }
    }
}
