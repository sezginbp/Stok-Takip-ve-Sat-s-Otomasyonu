
namespace stoktakip
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.lblSatisFiyat = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatisIptal = new System.Windows.Forms.Button();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.lblGenelToplam1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSatisListele = new System.Windows.Forms.Button();
            this.btnUrunlisteleme = new System.Windows.Forms.Button();
            this.btnUrunEkleme = new System.Windows.Forms.Button();
            this.btnMüsteriListeleme = new System.Windows.Forms.Button();
            this.btnMüsteriEkleme = new System.Windows.Forms.Button();
            this.btnMarka = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(236, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(966, 498);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTelefon);
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(25, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(2, 123);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblTelefon.TabIndex = 5;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(2, 81);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lblAdSoyad.TabIndex = 4;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(2, 40);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(20, 13);
            this.lblTc.TabIndex = 3;
            this.lblTc.Text = "Tc";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(71, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(92, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblToplamFiyat);
            this.groupBox2.Controls.Add(this.lblSatisFiyat);
            this.groupBox2.Controls.Add(this.lblAdet);
            this.groupBox2.Controls.Add(this.lblUrunAdi);
            this.groupBox2.Controls.Add(this.lblBarkodNo);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(25, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 288);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Location = new System.Drawing.Point(2, 218);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(67, 13);
            this.lblToplamFiyat.TabIndex = 10;
            this.lblToplamFiyat.Text = "Toplam Fiyat";
            // 
            // lblSatisFiyat
            // 
            this.lblSatisFiyat.AutoSize = true;
            this.lblSatisFiyat.Location = new System.Drawing.Point(2, 173);
            this.lblSatisFiyat.Name = "lblSatisFiyat";
            this.lblSatisFiyat.Size = new System.Drawing.Size(57, 13);
            this.lblSatisFiyat.TabIndex = 9;
            this.lblSatisFiyat.Text = "Satış Fiyatı";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(2, 128);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(29, 13);
            this.lblAdet.TabIndex = 8;
            this.lblAdet.Text = "Adet";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(2, 83);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(48, 13);
            this.lblUrunAdi.TabIndex = 7;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.Location = new System.Drawing.Point(2, 38);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(58, 13);
            this.lblBarkodNo.TabIndex = 6;
            this.lblBarkodNo.Text = "Barkod No";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(71, 211);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(92, 20);
            this.textBox8.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(71, 166);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(92, 20);
            this.textBox7.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(71, 121);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(92, 20);
            this.textBox6.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(71, 76);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(92, 20);
            this.textBox5.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(71, 31);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(92, 20);
            this.textBox4.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(236, 620);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(108, 26);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Location = new System.Drawing.Point(1094, 620);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(108, 26);
            this.btnSatisYap.TabIndex = 4;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1208, 96);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(74, 39);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnSatisIptal
            // 
            this.btnSatisIptal.Location = new System.Drawing.Point(1208, 160);
            this.btnSatisIptal.Name = "btnSatisIptal";
            this.btnSatisIptal.Size = new System.Drawing.Size(74, 39);
            this.btnSatisIptal.TabIndex = 6;
            this.btnSatisIptal.Text = "Satış İptal";
            this.btnSatisIptal.UseVisualStyleBackColor = true;
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(698, 633);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(73, 13);
            this.lblGenelToplam.TabIndex = 7;
            this.lblGenelToplam.Text = "Genel Toplam";
            // 
            // lblGenelToplam1
            // 
            this.lblGenelToplam1.AutoSize = true;
            this.lblGenelToplam1.Location = new System.Drawing.Point(788, 633);
            this.lblGenelToplam1.Name = "lblGenelToplam1";
            this.lblGenelToplam1.Size = new System.Drawing.Size(0, 13);
            this.lblGenelToplam1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKategori);
            this.panel1.Controls.Add(this.btnMarka);
            this.panel1.Controls.Add(this.btnSatisListele);
            this.panel1.Controls.Add(this.btnUrunlisteleme);
            this.panel1.Controls.Add(this.btnUrunEkleme);
            this.panel1.Controls.Add(this.btnMüsteriListeleme);
            this.panel1.Controls.Add(this.btnMüsteriEkleme);
            this.panel1.Location = new System.Drawing.Point(45, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 73);
            this.panel1.TabIndex = 9;
            // 
            // btnSatisListele
            // 
            this.btnSatisListele.Location = new System.Drawing.Point(1099, 17);
            this.btnSatisListele.Name = "btnSatisListele";
            this.btnSatisListele.Size = new System.Drawing.Size(125, 45);
            this.btnSatisListele.TabIndex = 8;
            this.btnSatisListele.Text = "Satışları Listele";
            this.btnSatisListele.UseVisualStyleBackColor = true;
            // 
            // btnUrunlisteleme
            // 
            this.btnUrunlisteleme.Location = new System.Drawing.Point(563, 17);
            this.btnUrunlisteleme.Name = "btnUrunlisteleme";
            this.btnUrunlisteleme.Size = new System.Drawing.Size(125, 45);
            this.btnUrunlisteleme.TabIndex = 7;
            this.btnUrunlisteleme.Text = "Ürün Listeleme";
            this.btnUrunlisteleme.UseVisualStyleBackColor = true;
            // 
            // btnUrunEkleme
            // 
            this.btnUrunEkleme.Location = new System.Drawing.Point(432, 17);
            this.btnUrunEkleme.Name = "btnUrunEkleme";
            this.btnUrunEkleme.Size = new System.Drawing.Size(125, 45);
            this.btnUrunEkleme.TabIndex = 6;
            this.btnUrunEkleme.Text = "Ürün Ekleme";
            this.btnUrunEkleme.UseVisualStyleBackColor = true;
            this.btnUrunEkleme.Click += new System.EventHandler(this.btnUrunEkleme_Click);
            // 
            // btnMüsteriListeleme
            // 
            this.btnMüsteriListeleme.Location = new System.Drawing.Point(207, 17);
            this.btnMüsteriListeleme.Name = "btnMüsteriListeleme";
            this.btnMüsteriListeleme.Size = new System.Drawing.Size(125, 45);
            this.btnMüsteriListeleme.TabIndex = 5;
            this.btnMüsteriListeleme.Text = "Müşteri Listeleme";
            this.btnMüsteriListeleme.UseVisualStyleBackColor = true;
            this.btnMüsteriListeleme.Click += new System.EventHandler(this.btnMüsteriListeleme_Click);
            // 
            // btnMüsteriEkleme
            // 
            this.btnMüsteriEkleme.Location = new System.Drawing.Point(76, 17);
            this.btnMüsteriEkleme.Name = "btnMüsteriEkleme";
            this.btnMüsteriEkleme.Size = new System.Drawing.Size(125, 45);
            this.btnMüsteriEkleme.TabIndex = 0;
            this.btnMüsteriEkleme.Text = "Müşteri Ekleme";
            this.btnMüsteriEkleme.UseVisualStyleBackColor = true;
            this.btnMüsteriEkleme.Click += new System.EventHandler(this.btnMüsteriEkleme_Click);
            // 
            // btnMarka
            // 
            this.btnMarka.Location = new System.Drawing.Point(765, 17);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(125, 45);
            this.btnMarka.TabIndex = 9;
            this.btnMarka.Text = "Marka";
            this.btnMarka.UseVisualStyleBackColor = true;
            this.btnMarka.Click += new System.EventHandler(this.btnMarka_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(896, 17);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(125, 45);
            this.btnKategori.TabIndex = 10;
            this.btnKategori.Text = "Kategori";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1294, 688);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGenelToplam1);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.btnSatisIptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.Label lblSatisFiyat;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblBarkodNo;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSatisIptal;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Label lblGenelToplam1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSatisListele;
        private System.Windows.Forms.Button btnUrunlisteleme;
        private System.Windows.Forms.Button btnUrunEkleme;
        private System.Windows.Forms.Button btnMüsteriListeleme;
        private System.Windows.Forms.Button btnMüsteriEkleme;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnMarka;
    }
}

