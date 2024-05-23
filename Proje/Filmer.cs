using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace _220601006_SERDARŞAHİN_FinalProjesi
{
    public partial class Filmer : Form
    {
        public Filmer()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglan = new NpgsqlConnection("Server=localhost; Port=5432; Database=postgres; User Id=postgres; Password=12345");

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

                // DataGridView'e verileri yükle
                DataGridView.DataSource = dt;
            }

            komut.Dispose();
            baglan.Close();
        }

        private void filmlerbtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM filmlerr";
            verilerigoster(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilmTuru filmTuru = new FilmTuru();
            filmTuru.Show();
            this.Hide();
        }

        private void filmadıaratxt_Click(object sender, EventArgs e)
        {
            filmÖzelikleri filmÖzelikleri = new filmÖzelikleri();
            filmÖzelikleri.Show();
            this.Hide();
        }

        private void geridonbtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Filmer_Load(object sender, EventArgs e)
        {

        }
    }
}
