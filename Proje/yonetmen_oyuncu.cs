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
    public partial class yonetmen_oyuncu : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("Host=localhost; Port=5432; Database=postgres; User Id=postgres; Password=12345");
        public yonetmen_oyuncu()
        {
            InitializeComponent();
        }

        private void filmsayısıbtn_Click(object sender, EventArgs e)
        {

            string yonetmenAdSoyad = Yonetmenadtxt.Text;

            if (!string.IsNullOrEmpty(yonetmenAdSoyad))
            {
                string query = $@"
                    SELECT
                        oyuncular.gercek_ad || ' ' || oyuncular.gercek_soyad AS oyuncu_adi,
                        COUNT(DISTINCT filmlerr.film_id) AS film_sayisi
                    FROM
                        oyuncuveyonetmenler
                    JOIN
                        oyuncular ON oyuncuveyonetmenler.oyuncuidsi = oyuncular.oyuncu_id
                    JOIN
                        filmlerr ON oyuncuveyonetmenler.filmidsi = filmlerr.film_id
                    JOIN
                        yonetmenler ON oyuncuveyonetmenler.yonetmenidsi = yonetmenler.yonetmen_id
                    WHERE
                        yonetmenler.gercek_ad || ' ' || yonetmenler.gercek_soyad ILIKE @yonetmenAdSoyad
                    GROUP BY
                        oyuncular.gercek_ad, oyuncular.gercek_soyad
                    ORDER BY
                        oyuncular.gercek_ad";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@yonetmenAdSoyad", $"%{yonetmenAdSoyad}%");

                    try
                    {
                        connection.Open();

                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Girilen yönetmen bulunamadı. Lütfen geçerli bir yönetmen adı ve soyadı girin.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir yönetmen adı ve soyadı girin.");
            }
        }

        private void geridonbtn_Click(object sender, EventArgs e)
        {

            Form1 formmm1 = new Form1();
            formmm1.Show();
            this.Hide();
        }
    }


}


