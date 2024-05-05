using System.Data.SqlClient;

namespace NotKasası
{
    public partial class Form1 : Form
    {
        AnaSayfa anaSayfa;
        kayit Kayit;
        public Form1()
        {
            InitializeComponent();
        }

        /**************** VERİ TABANI BAĞLANTI ****************/

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-DE2M4KD;Initial Catalog=NotDefteri2;Integrated Security=True;TrustServerCertificate=True");

        /**************** VERİ TABANI BAĞLANTI ****************/

        /**************** UYGULAMAYA GİRİŞ ****************/
        private void pictureBoxGirisYap_Click(object sender, EventArgs e)
        {
            string sifre = "";

            try
            {
                baglanti.Open();

                SqlCommand sqlkomut = new SqlCommand("SELECT kullaniciSifre FROM TableKullanicilar WHERE kullaniciAd = @p1", baglanti);
                sqlkomut.Parameters.AddWithValue("@p1", textBoxKullanıcıAd.Text);
                SqlDataReader sqlDataReader = sqlkomut.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    sifre = sqlDataReader[0].ToString();
                }

                if (sifre == textBoxSifre.Text)
                {
                    MessageBox.Show("Başarılı!");
                    anaSayfa = new AnaSayfa();
                    this.Hide();
                    anaSayfa.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adınız veya şifreniz hatalı lütfen tekrar deneyin!");
                    textBoxKullanıcıAd.Text = "";
                    textBoxSifre.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı Hatası!" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        /**************** UYGULAMAYA GİRİŞ ****************/

        /**************** KAYIT SAYFASINA GİT ****************/
        private void labelKayıtOl_Click(object sender, EventArgs e)
        {
            Kayit = new kayit();
            this.Hide();
            Kayit.Show();
        }

        /**************** KAYIT SAYFASINA GİT ****************/

        /**************** FORM KAPATMA ****************/
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /**************** FORM KAPATMA ****************/
    }
}