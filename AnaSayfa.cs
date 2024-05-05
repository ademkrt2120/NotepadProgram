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

namespace NotKasası
{
    public partial class AnaSayfa : Form
    {
        NotOluştur notOluştur;
        ListeOluştur listeOluştur;
        Hatırlatıcı hatırlatıcı;
        public AnaSayfa()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-DE2M4KD;Initial Catalog=NotDefteri2;Integrated Security=True;TrustServerCertificate=True");

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                string query = "SELECT TOP 1 NotBaslık FROM TableNotlar ORDER BY NotID DESC";

                using (SqlCommand command = new SqlCommand(query, baglanti))
                {

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        textBoxNot1.Text = result.ToString();
                    }
                    else
                    {
                        textBoxNot1.Text = "Veri bulunamadı.";
                    }
                }

                string query2 = "SELECT TOP 1 NotBaslık FROM TableNotlar WHERE NotID < (SELECT MAX(NotID) FROM TableNotlar) ORDER BY NotID DESC;";

                using (SqlCommand command2 = new SqlCommand(query2, baglanti))
                {
                    object result2 = command2.ExecuteScalar();

                    if (result2 != null)
                    {
                        textBoxNot2.Text = result2.ToString();
                    }
                    else
                    {
                        textBoxNot2.Text = "Veri Bulunamadı.";
                    }
                }

                string query3 = "SELECT TOP 1 görevIsmi FROM TableGörevler WHERE listID < (SELECT MAX(listID) FROM TableGörevler) ORDER BY listID DESC;";

                using (SqlCommand command3 = new SqlCommand(query3, baglanti))
                {
                    object result3 = command3.ExecuteScalar();

                    if (result3 != null)
                    {
                        textBoxListe2.Text = result3.ToString();
                    }
                    else
                    {
                        textBoxListe2.Text = "Veri Bulunamadı";
                    }
                }

                string query4 = "SELECT TOP 1 görevIsmi FROM TableGörevler ORDER BY listID DESC";

                using (SqlCommand command4 = new SqlCommand(query4, baglanti))
                {
                    object result4 = command4.ExecuteScalar();

                    if (result4 != null)
                    {
                        textBoxListe1.Text = result4.ToString();
                    }
                    else
                    {
                        textBoxListe1.Text = "Veri bulunamadı.";
                    }
                }

                string query5 = "SELECT TOP 1 Yapilacak FROM TableHatirlatici ORDER BY ID DESC";

                using (SqlCommand command5 = new SqlCommand(query5, baglanti))
                {
                    object result5 = command5.ExecuteScalar();

                    if (result5 != null)
                    {
                        richTextBoxHatirlatici.Text = result5.ToString();
                    }
                    else
                    {
                        richTextBoxHatirlatici.Text = "Hatirlatici Yok";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Son eklenen not çekilirken bir hata oluştu !" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            timer1.Start();
            labelZaman.Text = DateTime.Now.ToLongTimeString();
            labelTarih.Text = DateTime.Now.ToLongDateString();
        }

        private void buttonNotOlustur_Click(object sender, EventArgs e)
        {
            notOluştur = new NotOluştur();
            this.Hide();
            notOluştur.Show();
        }

        private void buttonListeOlustur_Click(object sender, EventArgs e)
        {
            listeOluştur = new ListeOluştur();
            this.Hide();
            listeOluştur.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hatırlatıcı = new Hatırlatıcı();
            this.Hide();
            hatırlatıcı.Show();
        }

        private void pictureBoxDüzenle1_Click(object sender, EventArgs e)
        {
            notOluştur = new NotOluştur();
            this.Hide();
            notOluştur.Show();
        }

        private void pictureBoxDüzenle2_Click(object sender, EventArgs e)
        {
            notOluştur = new NotOluştur();
            this.Hide();
            notOluştur.Show();
        }

        private void pictureBoxDüzenle3_Click(object sender, EventArgs e)
        {
            listeOluştur = new ListeOluştur();
            this.Hide();
            listeOluştur.Show();
        }

        private void pictureBoxDüzenle4_Click(object sender, EventArgs e)
        {
            listeOluştur = new ListeOluştur();
            this.Hide();
            listeOluştur.Show();
        }

        private void AnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelZaman.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
