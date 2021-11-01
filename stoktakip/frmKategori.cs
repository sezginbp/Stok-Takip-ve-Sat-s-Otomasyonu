using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace stoktakip
{
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=sezgin@sql;Initial Catalog=Stok_Takip;Integrated Security=True");

        private void frmKategori_Load(object sender, EventArgs e)
        {

        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into KategoriBilgileri(Kategori) values('"+txtKategori.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            txtKategori.Text = "";
            MessageBox.Show("Kategori Eklendi.");


        }
    }
}
