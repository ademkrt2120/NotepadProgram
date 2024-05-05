namespace NotKasası
{
    partial class Hatırlatıcı
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hatırlatıcı));
            labelID = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBoxYapilacak = new TextBox();
            dataGridViewHatirlatici = new DataGridView();
            buttonSil = new Button();
            buttonGüncelle = new Button();
            buttonNotEkle = new Button();
            buttonHatırlatıcı = new Button();
            buttonListeOlustur = new Button();
            buttonNotOlustur = new Button();
            buttonAnaSayfa = new Button();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBoxIcon = new ComboBox();
            ımageList1 = new ImageList(components);
            buttonTemizle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHatirlatici).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.BackColor = Color.FromArgb(224, 224, 224);
            labelID.Font = new Font("Nunito Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelID.Location = new Point(327, 211);
            labelID.Name = "labelID";
            labelID.Size = new Size(16, 20);
            labelID.TabIndex = 77;
            labelID.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(224, 224, 224);
            label5.Font = new Font("Nunito Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(159, 211);
            label5.Name = "label5";
            label5.Size = new Size(162, 20);
            label5.TabIndex = 76;
            label5.Text = "Seçili Yapılacak ID :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.Font = new Font("Nunito Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(280, 22);
            label4.Name = "label4";
            label4.Size = new Size(161, 41);
            label4.TabIndex = 75;
            label4.Text = "Hatırlatıcı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.Font = new Font("Nunito", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(159, 70);
            label3.Name = "label3";
            label3.Size = new Size(95, 24);
            label3.TabIndex = 74;
            label3.Text = "Yapılacak :";
            // 
            // textBoxYapilacak
            // 
            textBoxYapilacak.BorderStyle = BorderStyle.FixedSingle;
            textBoxYapilacak.Font = new Font("Nunito", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxYapilacak.Location = new Point(159, 98);
            textBoxYapilacak.Multiline = true;
            textBoxYapilacak.Name = "textBoxYapilacak";
            textBoxYapilacak.Size = new Size(386, 37);
            textBoxYapilacak.TabIndex = 73;
            textBoxYapilacak.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewHatirlatici
            // 
            dataGridViewHatirlatici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHatirlatici.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(18, 36, 50);
            dataGridViewCellStyle1.Font = new Font("Nunito Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewHatirlatici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewHatirlatici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHatirlatici.Location = new Point(159, 248);
            dataGridViewHatirlatici.Name = "dataGridViewHatirlatici";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 36, 50);
            dataGridViewCellStyle2.Font = new Font("Nunito Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewHatirlatici.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewHatirlatici.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(18, 36, 50);
            dataGridViewCellStyle3.Font = new Font("Nunito Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewHatirlatici.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewHatirlatici.RowTemplate.Height = 29;
            dataGridViewHatirlatici.Size = new Size(386, 345);
            dataGridViewHatirlatici.TabIndex = 72;
            dataGridViewHatirlatici.CellClick += dataGridViewHatirlatici_CellClick;
            // 
            // buttonSil
            // 
            buttonSil.BackColor = Color.FromArgb(224, 224, 224);
            buttonSil.Cursor = Cursors.Hand;
            buttonSil.FlatAppearance.BorderSize = 0;
            buttonSil.FlatStyle = FlatStyle.Flat;
            buttonSil.Font = new Font("Nunito Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSil.ForeColor = Color.Black;
            buttonSil.Image = Properties.Resources.bin2;
            buttonSil.ImageAlign = ContentAlignment.TopCenter;
            buttonSil.Location = new Point(457, 629);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(88, 107);
            buttonSil.TabIndex = 71;
            buttonSil.Text = "Görev\r\nSil";
            buttonSil.TextAlign = ContentAlignment.BottomCenter;
            buttonSil.UseVisualStyleBackColor = false;
            buttonSil.Click += buttonSil_Click;
            // 
            // buttonGüncelle
            // 
            buttonGüncelle.BackColor = Color.FromArgb(224, 224, 224);
            buttonGüncelle.Cursor = Cursors.Hand;
            buttonGüncelle.FlatAppearance.BorderSize = 0;
            buttonGüncelle.FlatStyle = FlatStyle.Flat;
            buttonGüncelle.Font = new Font("Nunito Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGüncelle.ForeColor = Color.Black;
            buttonGüncelle.Image = Properties.Resources.refresh__1_;
            buttonGüncelle.ImageAlign = ContentAlignment.TopCenter;
            buttonGüncelle.Location = new Point(255, 627);
            buttonGüncelle.Name = "buttonGüncelle";
            buttonGüncelle.Size = new Size(88, 108);
            buttonGüncelle.TabIndex = 70;
            buttonGüncelle.Text = "Görev\r\nGüncelle";
            buttonGüncelle.TextAlign = ContentAlignment.BottomCenter;
            buttonGüncelle.UseVisualStyleBackColor = false;
            buttonGüncelle.Click += buttonGüncelle_Click;
            // 
            // buttonNotEkle
            // 
            buttonNotEkle.BackColor = Color.FromArgb(224, 224, 224);
            buttonNotEkle.Cursor = Cursors.Hand;
            buttonNotEkle.FlatAppearance.BorderSize = 0;
            buttonNotEkle.FlatStyle = FlatStyle.Flat;
            buttonNotEkle.Font = new Font("Nunito Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNotEkle.ForeColor = Color.Black;
            buttonNotEkle.Image = Properties.Resources.add2;
            buttonNotEkle.ImageAlign = ContentAlignment.TopCenter;
            buttonNotEkle.Location = new Point(159, 628);
            buttonNotEkle.Name = "buttonNotEkle";
            buttonNotEkle.Size = new Size(88, 107);
            buttonNotEkle.TabIndex = 69;
            buttonNotEkle.Text = "Görev Ekle";
            buttonNotEkle.TextAlign = ContentAlignment.BottomCenter;
            buttonNotEkle.UseVisualStyleBackColor = false;
            buttonNotEkle.Click += buttonNotEkle_Click;
            // 
            // buttonHatırlatıcı
            // 
            buttonHatırlatıcı.BackColor = Color.FromArgb(18, 36, 50);
            buttonHatırlatıcı.Cursor = Cursors.Hand;
            buttonHatırlatıcı.FlatAppearance.BorderSize = 0;
            buttonHatırlatıcı.FlatStyle = FlatStyle.Flat;
            buttonHatırlatıcı.Font = new Font("Nunito SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHatırlatıcı.ForeColor = Color.White;
            buttonHatırlatıcı.Image = Properties.Resources.bell3;
            buttonHatırlatıcı.ImageAlign = ContentAlignment.TopCenter;
            buttonHatırlatıcı.Location = new Point(17, 621);
            buttonHatırlatıcı.Name = "buttonHatırlatıcı";
            buttonHatırlatıcı.Size = new Size(97, 99);
            buttonHatırlatıcı.TabIndex = 68;
            buttonHatırlatıcı.Text = "Hatırlatıcı";
            buttonHatırlatıcı.TextAlign = ContentAlignment.BottomCenter;
            buttonHatırlatıcı.UseVisualStyleBackColor = false;
            // 
            // buttonListeOlustur
            // 
            buttonListeOlustur.BackColor = Color.FromArgb(18, 36, 50);
            buttonListeOlustur.Cursor = Cursors.Hand;
            buttonListeOlustur.FlatAppearance.BorderSize = 0;
            buttonListeOlustur.FlatStyle = FlatStyle.Flat;
            buttonListeOlustur.Font = new Font("Nunito SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonListeOlustur.ForeColor = Color.White;
            buttonListeOlustur.Image = Properties.Resources.to_do_list3;
            buttonListeOlustur.ImageAlign = ContentAlignment.TopCenter;
            buttonListeOlustur.Location = new Point(12, 491);
            buttonListeOlustur.Name = "buttonListeOlustur";
            buttonListeOlustur.Size = new Size(106, 99);
            buttonListeOlustur.TabIndex = 67;
            buttonListeOlustur.Text = "Liste Oluştur";
            buttonListeOlustur.TextAlign = ContentAlignment.BottomCenter;
            buttonListeOlustur.UseVisualStyleBackColor = false;
            buttonListeOlustur.Click += buttonListeOlustur_Click;
            // 
            // buttonNotOlustur
            // 
            buttonNotOlustur.BackColor = Color.FromArgb(18, 36, 50);
            buttonNotOlustur.Cursor = Cursors.Hand;
            buttonNotOlustur.FlatAppearance.BorderSize = 0;
            buttonNotOlustur.FlatStyle = FlatStyle.Flat;
            buttonNotOlustur.Font = new Font("Nunito SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNotOlustur.ForeColor = Color.White;
            buttonNotOlustur.Image = Properties.Resources.notes2;
            buttonNotOlustur.ImageAlign = ContentAlignment.TopCenter;
            buttonNotOlustur.Location = new Point(12, 361);
            buttonNotOlustur.Name = "buttonNotOlustur";
            buttonNotOlustur.Size = new Size(106, 99);
            buttonNotOlustur.TabIndex = 66;
            buttonNotOlustur.Text = "Not Oluştur";
            buttonNotOlustur.TextAlign = ContentAlignment.BottomCenter;
            buttonNotOlustur.UseVisualStyleBackColor = false;
            buttonNotOlustur.Click += buttonNotOlustur_Click;
            // 
            // buttonAnaSayfa
            // 
            buttonAnaSayfa.BackColor = Color.FromArgb(18, 36, 50);
            buttonAnaSayfa.Cursor = Cursors.Hand;
            buttonAnaSayfa.FlatAppearance.BorderSize = 0;
            buttonAnaSayfa.FlatStyle = FlatStyle.Flat;
            buttonAnaSayfa.Font = new Font("Nunito SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAnaSayfa.ForeColor = Color.White;
            buttonAnaSayfa.Image = Properties.Resources.home__6_;
            buttonAnaSayfa.ImageAlign = ContentAlignment.TopCenter;
            buttonAnaSayfa.Location = new Point(17, 231);
            buttonAnaSayfa.Name = "buttonAnaSayfa";
            buttonAnaSayfa.Size = new Size(97, 99);
            buttonAnaSayfa.TabIndex = 65;
            buttonAnaSayfa.Text = "Ana Sayfa";
            buttonAnaSayfa.TextAlign = ContentAlignment.BottomCenter;
            buttonAnaSayfa.UseVisualStyleBackColor = false;
            buttonAnaSayfa.Click += buttonAnaSayfa_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(18, 36, 50);
            pictureBox3.Image = Properties.Resources._11;
            pictureBox3.Location = new Point(19, 156);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(86, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 64;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(18, 36, 50);
            label2.Font = new Font("Nunito", 7.799999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 125);
            label2.Name = "label2";
            label2.Size = new Size(81, 18);
            label2.TabIndex = 63;
            label2.Text = "Profil Göster";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(18, 36, 50);
            label1.Font = new Font("Nunito SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 102);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 62;
            label1.Text = "Kullanıcı İsmi";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(18, 36, 50);
            pictureBox2.Image = Properties.Resources._10;
            pictureBox2.Location = new Point(29, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 61;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(18, 36, 50);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources._33;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(582, 780);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(224, 224, 224);
            label6.Font = new Font("Nunito", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(159, 143);
            label6.Name = "label6";
            label6.Size = new Size(277, 24);
            label6.TabIndex = 79;
            label6.Text = "Hatırlatıcı zamanı ve bir ikon seç :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(159, 175);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(237, 27);
            dateTimePicker1.TabIndex = 80;
            // 
            // comboBoxIcon
            // 
            comboBoxIcon.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxIcon.FlatStyle = FlatStyle.Flat;
            comboBoxIcon.FormattingEnabled = true;
            comboBoxIcon.ItemHeight = 50;
            comboBoxIcon.Location = new Point(412, 174);
            comboBoxIcon.Name = "comboBoxIcon";
            comboBoxIcon.Size = new Size(133, 56);
            comboBoxIcon.TabIndex = 81;
            comboBoxIcon.DrawItem += comboBoxIcon_DrawItem;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "hourglass.png");
            ımageList1.Images.SetKeyName(1, "snail (1).png");
            ımageList1.Images.SetKeyName(2, "urgent (1).png");
            // 
            // buttonTemizle
            // 
            buttonTemizle.BackColor = Color.FromArgb(224, 224, 224);
            buttonTemizle.Cursor = Cursors.Hand;
            buttonTemizle.FlatAppearance.BorderSize = 0;
            buttonTemizle.FlatStyle = FlatStyle.Flat;
            buttonTemizle.Font = new Font("Nunito Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTemizle.ForeColor = Color.Black;
            buttonTemizle.Image = Properties.Resources.eraser__2___1_;
            buttonTemizle.ImageAlign = ContentAlignment.TopCenter;
            buttonTemizle.Location = new Point(361, 629);
            buttonTemizle.Name = "buttonTemizle";
            buttonTemizle.Size = new Size(88, 93);
            buttonTemizle.TabIndex = 82;
            buttonTemizle.Text = "Temizle";
            buttonTemizle.TextAlign = ContentAlignment.BottomCenter;
            buttonTemizle.UseVisualStyleBackColor = false;
            buttonTemizle.Click += button1_Click;
            // 
            // Hatırlatıcı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 780);
            Controls.Add(buttonTemizle);
            Controls.Add(comboBoxIcon);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(labelID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxYapilacak);
            Controls.Add(dataGridViewHatirlatici);
            Controls.Add(buttonSil);
            Controls.Add(buttonGüncelle);
            Controls.Add(buttonNotEkle);
            Controls.Add(buttonHatırlatıcı);
            Controls.Add(buttonListeOlustur);
            Controls.Add(buttonNotOlustur);
            Controls.Add(buttonAnaSayfa);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Hatırlatıcı";
            Text = "Hatırlatıcı";
            FormClosed += Hatırlatıcı_FormClosed;
            Load += Hatırlatıcı_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHatirlatici).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelID;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBoxYapilacak;
        private DataGridView dataGridViewHatirlatici;
        private Button buttonSil;
        private Button buttonGüncelle;
        private Button buttonNotEkle;
        private Button buttonHatırlatıcı;
        private Button buttonListeOlustur;
        private Button buttonNotOlustur;
        private Button buttonAnaSayfa;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxIcon;
        private ImageList ımageList1;
        private Button buttonTemizle;
    }
}