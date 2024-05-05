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
    public partial class NotOluştur : Form
    {
        AnaSayfa anaSayfa;
        ListeOluştur listeOluştur;
        Hatırlatıcı hatırlatıcı;
        public NotOluştur()
        {
            InitializeComponent();
        }

        /**************** VERİ TABANI BAĞLANTISI ****************/

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-DE2M4KD;Initial Catalog=NotDefteri2;Integrated Security=True;TrustServerCertificate=True");

        /**************** VERİ TABANI BAĞLANTISI ****************/

        /**************** VERİ TABANI VERİ GÖSTER ****************/

        private void VerileriGöster()
        {
            try
            {
                string g = "SELECT * FROM TableNotlar";
                SqlDataAdapter da = new SqlDataAdapter(g, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewNotlar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Notlar gösterilirken veri tabanında bir hata oluştu!" + ex.Message);
            }
        }

        /*Kod Açıklaması :
         
        
         
        */

        /**************** VERİ TABANI VERİ GÖSTER ****************/

        /**************** DATA GRİD VİEW CELLCLİCK ****************/
        private void dataGridViewNotlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenNot = dataGridViewNotlar.SelectedCells[0].RowIndex;
            labelID.Text = dataGridViewNotlar.Rows[secilenNot].Cells[0].Value.ToString();
            textBoxBaslık.Text = dataGridViewNotlar.Rows[secilenNot].Cells[1].Value.ToString();
            richTextBoxaAcıklama.Text = dataGridViewNotlar.Rows[secilenNot].Cells[2].Value.ToString();

            //Date Time Picker
            object secilenTarihObj = dataGridViewNotlar.Rows[secilenNot].Cells["ZamanTarih"].Value;
            if (secilenTarihObj != DBNull.Value)
            {
                DateTime secilenTarih = Convert.ToDateTime(secilenTarihObj);
                dateTimePicker1.Value = secilenTarih;
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now;
            }
            /*
            
             => Bu yapı, bir DataGridView içindeki hücrelerden veri almayı ve bu 
            veriyi işlemeyi sağlar. Eğer hücredeki değer bir tarih ve saat ise, bu 
            değeri bir DateTime nesnesine dönüştürerek DateTimePicker kontrolüne atar. 
            Eğer hücre boşsa, şu anki zamanı varsayılan değer olarak kullanır.
            
            -> secilenTarihObj adında bir değişken oluşturulur ve bu değişkene 
            DataGridView kontrolünde belirli bir satırdaki "ZamanTarih" adlı hücrenin 
            değeri atanır.

            -> dataGridViewNotlar.Rows: DataGridView kontrolündeki satırları temsil 
            eder. Bir DataGridView nesnesinin Rows özelliği, bir koleksiyon döndürür 
            ve her bir elemanı bir satırı temsil eder. Bu koleksiyon üzerinde, satırları
            ekleme, silme, düzenleme gibi işlemler yapılabilir.

            -> dataGridViewNotlar.Cells: DataGridView kontrolündeki hücreleri temsil 
            eder. Bir DataGridViewRow nesnesinin Cells özelliği, o satırdaki hücreleri 
            temsil eden bir koleksiyon döndürür. Her bir eleman, bir hücreyi temsil eder. 
            Bu özellik sayesinde hücrelere erişilebilir, hücre değerleri okunabilir veya 
            değiştirilebilir.

            -> secilenTarihObj değişkeni DBNull.Value ile karşılaştırılır. Bu kontrol, 
            hücrenin boş olup olmadığını kontrol eder.

            -> Eğer secilenTarihObj boş değilse (DBNull.Value değilse), o zaman bu değer 
            bir DateTime nesnesine dönüştürülür (Convert.ToDateTime(secilenTarihObj)).
            Dönüşüm başarılıysa, elde edilen DateTime değeri dateTimePicker1 kontrolünün 
            değeri olarak atanır.

            -> DateTime bir .NET Framework'te bulunan bir sınıftır ve tarih ve saat 
            değerlerini temsil eder. Tarih ve saat işlemleri için birçok yöntem ve özellik 
            sağlar.

            -> .ToDateTime ise, bir değeri DateTime türüne dönüştürmek için kullanılan 
            bir dönüşüm metodu veya işlevidir. Bu metot, bir değeri DateTime türüne 
            dönüştürürken kullanılır. Ancak, doğrudan kullanımı gerektiği durumlarda sadece 
            bazı özel durumlar için kullanılabilir, çünkü genellikle dönüştürme işlemleri 
            için daha güvenli ve doğru dönüşüm yöntemleri tercih edilir.

            -> Eğer uygun formatta değilse veya boş bir stringse bu yöntem hata verebilir. 
            Bu nedenle dönüşüm işlemlerinde dikkatli olmak önemlidir.

            */

            DateTime secilenTarih2 = dateTimePicker1.Value;
            DateTime suAnkiTarih = DateTime.Now;
            TimeSpan tarihFarki = suAnkiTarih - secilenTarih2;
            labelGün.Text = "Bu not " + $"{tarihFarki.Days}" + " gün önce oluşturuldu";

            /*
            => Bu kod bloğu, bir DateTimePicker kontrolünden seçilen bir tarihi ve şu anki 
            tarihi alarak aralarındaki farkı hesaplar ve bu farkı bir etikete yazdırır. 
            İşleyiş şu adımlarla gerçekleşir: 

            -> DateTime suAnkiTarih = DateTime.Now;: Şu anki tarihi suAnkiTarih adlı bir 
            DateTime değişkenine atar. DateTime.Now fonksiyonu, bilgisayarın sistem saatini 
            döndürür. 
            */

            string font = dataGridViewNotlar.Rows[secilenNot].Cells[4].Value.ToString();
            if (!string.IsNullOrEmpty(font))
            {
                comboBoxFont.Text = font;
            }

            string boyut = dataGridViewNotlar.Rows[secilenNot].Cells[3].Value.ToString();
            if (!string.IsNullOrEmpty(boyut))
            {
                comboBoxBoyut.Text = boyut;
            }

            string renkArgbString = dataGridViewNotlar.Rows[secilenNot].Cells[5].Value.ToString();
            if (!string.IsNullOrEmpty(renkArgbString))
            {
                int renkArgb = Convert.ToInt32(renkArgbString);
                Color renk = Color.FromArgb(renkArgb);
                richTextBoxaAcıklama.ForeColor = renk;
            }
        }

        /**************** DATA GRİD VİEW CELLCLİCK ****************/

        /**************** FORM LOAD ****************/
        private void NotOluştur_Load(object sender, EventArgs e)
        {
            VerileriGöster();

            foreach (FontFamily font in FontFamily.Families)
            {
                comboBoxFont.Items.Add(font.Name.ToString());
            }
        }

        /**************** FORM LOAD ****************/

        /**************** BUTON YÖNLENDİRME ****************/
        private void buttonAnaSayfa_Click(object sender, EventArgs e)
        {
            anaSayfa = new AnaSayfa();
            this.Hide();
            anaSayfa.Show();
        }

        private void buttonListeOlustur_Click(object sender, EventArgs e)
        {
            listeOluştur = new ListeOluştur();
            this.Hide();
            listeOluştur.Show();
        }

        private void buttonHatırlatıcı_Click(object sender, EventArgs e)
        {
            hatırlatıcı = new Hatırlatıcı();
            this.Hide();
            hatırlatıcı.Show();
        }

        /**************** BUTON YÖNLENDİRME ****************/

        /**************** VERİ TABANI EKLEME İŞLEMİ ****************/
        private void buttonNotEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                Font selectedFont = richTextBoxaAcıklama.Font;
                string fontName = selectedFont.Name;
                float fontSize = selectedFont.Size;
                Color fontColor = richTextBoxaAcıklama.ForeColor;

                SqlCommand sqlCommand = new SqlCommand("INSERT INTO TableNotlar (NotBaslık,NotAcıklama,MetinBoyut,MetinFont,MetinRenk,ZamanTarih)" +
                    "VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);

                sqlCommand.Parameters.AddWithValue("@P1", textBoxBaslık.Text);
                sqlCommand.Parameters.AddWithValue("@P2", richTextBoxaAcıklama.Text);
                sqlCommand.Parameters.AddWithValue("@P3", fontSize);
                sqlCommand.Parameters.AddWithValue("@P4", fontName);
                sqlCommand.Parameters.AddWithValue("@P5", fontColor.ToArgb());
                sqlCommand.Parameters.AddWithValue("@P6", dateTimePicker1.Value);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not eklenirken bir hata oluştu!" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            VerileriGöster();
        }

        /**************** VERİ TABANI EKLEME İŞLEMİ ****************/

        /**************** KUTULARI TEMİZLE ****************/
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxBaslık.Text = "";
            richTextBoxaAcıklama.Text = "";
        }

        /**************** KUTULARI TEMİZLE ****************/

        /**************** VERİ TABANI GÜNCELLEME İŞLEMİ ****************/
        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE TableNotlar SET NotBaslık = @P1," +
                    "NotAcıklama = @P2, ZamanTarih = @P4 WHERE NotID = @P3", baglanti);

                sqlCommand.Parameters.AddWithValue("@P1", textBoxBaslık.Text);
                sqlCommand.Parameters.AddWithValue("@P2", richTextBoxaAcıklama.Text);
                sqlCommand.Parameters.AddWithValue("@P3", labelID.Text);
                sqlCommand.Parameters.AddWithValue("@P4", dateTimePicker1.Value);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not güncellenirken bir hata oluştu lütfen tekrar deneyin!" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            VerileriGöster();
        }

        /**************** VERİ TABANI GÜNCELLEME İŞLEMİ ****************/

        /**************** VERİ TABANI SİLME İŞLEMİ ****************/
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

                    SqlCommand silKomut = new SqlCommand("DELETE FROM TableNotlar WHERE NotID = @P1", baglanti);
                    silKomut.Parameters.AddWithValue("@P1", labelID.Text);

                    silKomut.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Seçtiğiniz not silinirken bir hata oluştu!" + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }

                VerileriGöster();
                button1_Click(sender, e);
            }
        }

        /**************** VERİ TABANI SİLME İŞLEMİ ****************/

        /**************** METİN FONT ****************/
        public void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                richTextBoxaAcıklama.Font = new Font(comboBoxFont.Text, richTextBoxaAcıklama.Font.Size);
                string selectedFont = comboBoxFont.Text;

                SqlCommand sqlCommand = new SqlCommand("UPDATE TableNotlar SET MetinFont = @Font WHERE NotID = @ID", baglanti);
                sqlCommand.Parameters.AddWithValue("@Font", selectedFont);
                sqlCommand.Parameters.AddWithValue("@ID", labelID.Text);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Font uygulanırken bir hata oluştu !" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            VerileriGöster();
        }

        /**************** METİN FONT ****************/

        /**************** METİN SİZE ****************/
        private void comboBoxBoyut_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                richTextBoxaAcıklama.Font = new Font(richTextBoxaAcıklama.Font.FontFamily, float.Parse(comboBoxBoyut.SelectedIndex.ToString()));
                string selectedSize = comboBoxBoyut.Text;

                SqlCommand sqlCommand = new SqlCommand("UPDATE TableNotlar SET MetinBoyut = @Size WHERE NotID = @ID", baglanti);
                sqlCommand.Parameters.AddWithValue("@Size", selectedSize);
                sqlCommand.Parameters.AddWithValue("@ID", labelID.Text);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Metin boyutlandırılırken bir hata oluştu !" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            VerileriGöster();
        }

        /**************** METİN SİZE ****************/

        /**************** METİN RENK ****************/
        private void buttonRenk_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                ColorDialog colorDialog = new ColorDialog();

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;

                    richTextBoxaAcıklama.ForeColor = selectedColor;

                    int argbValue = selectedColor.ToArgb();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableNotlar SET MetinRenk = @Color WHERE NotID = @ID", baglanti);
                    sqlCommand.Parameters.AddWithValue("@Color", argbValue);
                    sqlCommand.Parameters.AddWithValue("@ID", labelID.Text);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Metin rengi değiştirilirken bir hata oluştu !" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            VerileriGöster();
        }
        /**************** METİN RENK ****************/

        private void NotOluştur_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }       
    }
}
