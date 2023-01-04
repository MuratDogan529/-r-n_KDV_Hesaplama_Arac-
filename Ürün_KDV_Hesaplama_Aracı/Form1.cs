using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ürün_KDV_Hesaplama_Aracı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Kdvsizfiyat,kdvlifiyat,kdvoran;
            kdvlifiyat = double.Parse(txtKDVliFiyat.Text);
            kdvoran = double.Parse(txtKDVOran.Text);

            Kdvsizfiyat=kdvlifiyat / (1 + kdvoran / 100);
            txtKDVsizFiyat.Text = Kdvsizfiyat.ToString();
            txtKDV.Text=(kdvlifiyat - Kdvsizfiyat).ToString();

        }
    }
}
