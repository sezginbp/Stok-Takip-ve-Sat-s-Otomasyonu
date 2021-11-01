using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stoktakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMüsteriEkleme_Click(object sender, EventArgs e)
        {
            frmMüsteriEkle ekle = new frmMüsteriEkle();
            ekle.ShowDialog();


        }

        private void btnMüsteriListeleme_Click(object sender, EventArgs e)
        {
            frmMüşteriListeleme listele = new frmMüşteriListeleme();
            listele.ShowDialog();

            
        }

        private void btnUrunEkleme_Click(object sender, EventArgs e)
        {
            frmÜrünEkleme ekle = new frmÜrünEkleme();
            ekle.ShowDialog();


        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();

        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();

        }
    }
}
