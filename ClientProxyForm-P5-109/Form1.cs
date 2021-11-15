using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxyForm_P5_109
{
    ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(textBox1.Text);
            int angka2 = Convert.ToInt32(textBox2.Text);

            double hTambah = obj.Tambah(angka1, angka2);
            double hKurang = obj.Kurang(angka1, angka2);
            double hKali = obj.Kali(angka1, angka2);
            double hBagi = obj.Bagi(angka1, angka2);

            labelpenjumlahan.Text = hTambah.ToString();
            labelpengurangan.Text = hKurang.ToString();
            labelperkalian.Text = hKali.ToString();
            labelpembagian.Text = hBagi.ToString();
        }
    }
}
