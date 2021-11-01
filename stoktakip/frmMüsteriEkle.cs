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
    public partial class frmMüsteriEkle : Form
    {
        public frmMüsteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=sezgin\\sql;Initial Catalog=Stok_Takip;Integrated Security=True");
        private void frmMüsteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnEkleME_Click(object sender, EventArgs e)
        {
            baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into müşteri(TC,AdSoyad,Telefon,Adres,Email) values(@TC,@AdSoyad,@Telefon,@Adres,@Email)", baglanti);
            komut.Parameters.AddWithValue("@TC", txtTcME.Text);
            komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyadME.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTelefonME.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdresME.Text);
            komut.Parameters.AddWithValue("@Email", txtEmailME.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Eklendi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }
    }
}
    }
}