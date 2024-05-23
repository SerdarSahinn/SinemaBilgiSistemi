namespace _220601006_SERDARŞAHİN_FinalProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void filmbtn_Click(object sender, EventArgs e)
        {
            Filmer filmer = new Filmer();
            filmer.Show();
            this.Hide();
        }

        private void ÖZELLİKGİTBTN_Click(object sender, EventArgs e)
        {
            yonetmen_oyuncu yonetmen_Oyuncu = new yonetmen_oyuncu();
            yonetmen_Oyuncu.Show();
            this.Hide();
        }

        private void oyuncubtn_Click(object sender, EventArgs e)
        {
            Oyuncular oyuncular = new Oyuncular();
            oyuncular.Show();
            this.Hide();
        }

        private void Yonetmenbtn_Click(object sender, EventArgs e)
        {
            Yonetmen yonetmen = new Yonetmen();
            yonetmen.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}