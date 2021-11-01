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

namespace stoktakip
{
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=sezgin@sql;Initial Catalog=Stok_Takip;Integrated Security=True");
        private void btnMarkaSayfasiEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MarkaBilgileri(Kategori,Marka) values('"+comboBox1.Text+"', '" + txtMarka.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            txtMarka.Text = "";
            comboBox1.Text = "";
            MessageBox.Show("Marka Eklendi.");

        }

        private void frmMarka_Load(object sender, EventArgs e)
        {
            Kategori_Getir();

        }

        private void Kategori_Getir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from KategoriBilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()) 
            {
                comboBox1.Items.Add(read["Kategori"].ToString());

            }
            baglanti.Close();
        }
    }
}
