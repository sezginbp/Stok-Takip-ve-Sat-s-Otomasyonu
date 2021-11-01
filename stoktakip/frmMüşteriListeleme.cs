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
    public partial class frmMüşteriListeleme : Form
    {
        public frmMüşteriListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=sezgin\\sql;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();

        private void MusteriListeleme_Load(object sender, EventArgs e)
        {
            Kayit_Goster();

        }

        private void Kayit_Goster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Müşteri", baglanti);
            adtr.Fill(daset, "Müşteri");
            dataGridView1.DataSource = daset.Tables["Müşteri"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTcML.Text = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            txtAdSoyadML.Text = dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
            txtTelefonML.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            txtAdresML.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
            txtEmailML.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
        }

        private void btnGuncelleML_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update müşteri set AdSoyad=@AdSoyad,Telefon=@Telefon,Adres=@Adres,Email=@Email where TC=@TC ", baglanti);
            komut.Parameters.AddWithValue("@TC", txtTcML.Text);
            komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyadML.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTelefonML.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdresML.Text);
            komut.Parameters.AddWithValue("@Email", txtEmailML.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Müşteri"].Clear();
            Kayit_Goster();
            MessageBox.Show("Müşteri Kaydı Güncellendi.");
            foreach (Control item in this.Controls)

            {
                if (item is TextBox)
                {
                    item.Text = "";

                }
            }

        }

        private void btnSilML_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Müşteri where TC='" + dataGridView1.CurrentRow.Cells["TC"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Kayit_Goster();
            MessageBox.Show("Müşteri Kaydı Silindi.");


        }

        private void txtTcAraML_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtc = new SqlDataAdapter("select * from Müşteri where TC LIKE '%" + txtTcAraML.Text + "%'", baglanti);
            adtc.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
