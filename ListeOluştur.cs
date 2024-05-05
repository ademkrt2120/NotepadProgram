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
    public partial class ListeOluştur : Form
    {
        AnaSayfa anaSayfa;
        Form1 form1;
        Hatırlatıcı hatırlatıcı;
        NotOluştur notOluştur;
        public ListeOluştur()
        {
            InitializeComponent();
        }

        /* YAĞMUR BEREKETOĞLU 222503224 */

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-DE2M4KD;Initial Catalog=NotDefteri2;Integrated Security=True;TrustServerCertificate=True");
        private void VeriGöster()
        {
            try
            {
                string g = "SELECT * FROM TableGörevler";
                SqlDataAdapter da = new SqlDataAdapter(g, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewListeler.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Görevler gösterilirken bir hata oluştu!");
            }
        }

        private void ListeOluştur_Load(object sender, EventArgs e)
        {
            VeriGöster();
        }

        private void buttonNotEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand sqlCommand = new SqlCommand("INSERT INTO TableGörevler (görevIsmi) " +
                    "VALUES (@P1)", baglanti);

                sqlCommand.Parameters.AddWithValue("@P1", textBoxGörevIsmi.Text);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Görev başarıyla eklendi :)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Görev eklenirken bir hata oluştu!" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            VeriGöster();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE TableGörevler SET görevIsmi = @P1" +
                    " WHERE listID = @P2", baglanti);

                sqlCommand.Parameters.AddWithValue("@P1", textBoxGörevIsmi.Text);
                sqlCommand.Parameters.AddWithValue("@P2", labelID.Text);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Güncelleme işlemi başarılı :)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not güncellenirken bir hata oluştu lütfen tekrar deneyin!" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            VeriGöster();
        }

        private void dataGridViewListeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenGörev = dataGridViewListeler.SelectedCells[0].RowIndex;
            labelID.Text = dataGridViewListeler.Rows[secilenGörev].Cells[0].Value.ToString();
            textBoxGörevIsmi.Text = dataGridViewListeler.Rows[secilenGörev].Cells[1].Value.ToString();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (labelID.Text == "-" || labelID.Text == "")
            {
                MessageBox.Show("Lütfen listeden silmek istediğiniz notu seçiniz!");
            }
            else
            {
                try
                {
                    baglanti.Open();

                    SqlCommand silKomut = new SqlCommand("DELETE FROM TableGörevler WHERE listID = @P1", baglanti);
                    silKomut.Parameters.AddWithValue("@P1", labelID.Text);
                    silKomut.ExecuteNonQuery();

                    MessageBox.Show("Görev başarıyla silindi :)");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Seçtiğiniz Görev silinirken bir hata oluştu!" + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                VeriGöster();
            }
        }

        private void buttonAnaSayfa_Click(object sender, EventArgs e)
        {
            anaSayfa = new AnaSayfa();
            this.Hide();
            anaSayfa.Show();
        }

        private void buttonNotOlustur_Click(object sender, EventArgs e)
        {
            notOluştur = new NotOluştur();
            this.Hide();
            notOluştur.Show();
        }

        private void buttonHatırlatıcı_Click(object sender, EventArgs e)
        {
            hatırlatıcı = new Hatırlatıcı();
            this.Hide();
            hatırlatıcı.Show();
        }

        private void ListeOluştur_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
