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
    public partial class kayit : Form
    {
        Form1 form1;
        public kayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-DE2M4KD;Initial Catalog=NotDefteri2;Integrated Security=True;TrustServerCertificate=True");
        private void kayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("INSERT INTO TableKullanicilar (kullaniciAd, kullaniciSifre)" +
                    "VALUES (@P1,@P2)", baglanti);

                komut.Parameters.AddWithValue("@P1", textBoxAd.Text);
                komut.Parameters.AddWithValue("@P2", textBoxSifre.Text);
                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt işlemi sırasında bir hata oluştu!" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            MessageBox.Show("Kayıt Başarılı");
            textBoxAd.Text = "";
            textBoxSifre.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void kayit_Load(object sender, EventArgs e)
        {

        }
    }
}
