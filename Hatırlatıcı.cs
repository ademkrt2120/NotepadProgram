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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NotKasası
{
    public partial class Hatırlatıcı : Form
    {

        AnaSayfa anaSayfa;
        ListeOluştur listeOluştur;
        NotOluştur notOluştur;
        public Hatırlatıcı()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-DE2M4KD;Initial Catalog=NotDefteri2;Integrated Security=True;TrustServerCertificate=True");
        private void VeriGöster()
        {
            try
            {
                string g = "SELECT * FROM TableHatirlatici";
                SqlDataAdapter da = new SqlDataAdapter(g, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewHatirlatici.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yapacaklarınız veri tabanından çekilirken bir hata oluştu !" + ex.Message);
            }
        }

        private void buttonNotEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                Image selectedImage = (Image)comboBoxIcon.SelectedItem;
                string base64Image = ImageToBase64(selectedImage);

                SqlCommand komut = new SqlCommand("INSERT INTO TableHatirlatici (Yapilacak,ZamanTarih,Resim) VALUES " +
                    "(@P1,@P2,@P3)", baglanti);
                komut.Parameters.AddWithValue("@P1", textBoxYapilacak.Text);
                komut.Parameters.AddWithValue("@P2", dateTimePicker1.Value);
                komut.Parameters.Add("@P3", SqlDbType.VarBinary).Value = Convert.FromBase64String(base64Image);
                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme işlemi sırasında hata oluştu! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            VeriGöster();
        }

        private string ImageToBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        private void comboBoxIcon_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ComboBox comboBox = (ComboBox)sender;
            Image image = (Image)comboBox.Items[e.Index];
            e.Graphics.DrawImage(image, e.Bounds.Location);
        }

        private void Hatırlatıcı_Load(object sender, EventArgs e)
        {
            VeriGöster();

            foreach (Image image in ımageList1.Images)
            {
                comboBoxIcon.Items.Add(image);
            }

            comboBoxIcon.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxIcon.DrawItem += comboBoxIcon_DrawItem;

        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                Image selectedImage = (Image)comboBoxIcon.SelectedItem;
                string base64Image = ImageToBase64(selectedImage);

                SqlCommand komut = new SqlCommand("UPDATE TableHatirlatici SET Yapilacak = @P1, ZamanTarih = @P2, " +
                    "Resim = @P3 WHERE ID = @P4", baglanti);
                komut.Parameters.AddWithValue("@P1", textBoxYapilacak.Text);
                komut.Parameters.AddWithValue("@P2", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@P4", labelID.Text);
                komut.Parameters.Add("@P3", SqlDbType.VarBinary).Value = Convert.FromBase64String(base64Image);
                komut.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme işlemi sırasında hata oluştu !" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            VeriGöster();
        }

        private void dataGridViewHatirlatici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenYapilacak = dataGridViewHatirlatici.SelectedCells[0].RowIndex;
            labelID.Text = dataGridViewHatirlatici.Rows[secilenYapilacak].Cells[0].Value.ToString();
            textBoxYapilacak.Text = dataGridViewHatirlatici.Rows[secilenYapilacak].Cells[1].Value.ToString();

            //Date Time
            object secilenTarihObj = dataGridViewHatirlatici.Rows[secilenYapilacak].Cells["ZamanTarih"].Value;
            if (secilenTarihObj != DBNull.Value)
            {
                DateTime secilenTarih = Convert.ToDateTime(secilenTarihObj);
                dateTimePicker1.Value = secilenTarih;
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now;
            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewHatirlatici.Rows[e.RowIndex];
                object value = row.Cells["Resim"].Value;
                if (value != DBNull.Value && value != null)
                {
                    byte[] imageBytes = (byte[])value;
                    Image selectedImage = ByteArrayToImage(imageBytes);
                    comboBoxIcon.Items.Clear();
                    comboBoxIcon.Items.Add(selectedImage);
                    comboBoxIcon.SelectedIndex = 0;
                }
                else
                {
                    comboBoxIcon.SelectedIndex = -1;
                    comboBoxIcon.Items.Clear();
                    foreach (Image image in ımageList1.Images)
                    {
                        comboBoxIcon.Items.Add(image);
                    }
                }
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxIcon.SelectedIndex = -1;
            comboBoxIcon.Items.Clear();
            foreach (Image image in ımageList1.Images)
            {
                comboBoxIcon.Items.Add(image);
            }

            textBoxYapilacak.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (labelID.Text == "-" || labelID.Text == "")
            {
                MessageBox.Show("Lütfen tablodan bir seçim yapın !");
            }
            else
            {
                try
                {
                    baglanti.Open();

                    SqlCommand silKomut = new SqlCommand("DELETE FROM TableHatirlatici WHERE ID = @P1", baglanti);
                    silKomut.Parameters.AddWithValue("@P1", labelID.Text);

                    silKomut.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri silinirken bir hata oluştu !" + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                VeriGöster();
            }
        }

        private void Hatırlatıcı_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void buttonListeOlustur_Click(object sender, EventArgs e)
        {
            listeOluştur = new ListeOluştur();
            this.Hide();
            listeOluştur.Show();
        }
    }
}
