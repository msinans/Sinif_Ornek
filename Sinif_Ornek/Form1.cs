using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinif_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba araba = new Araba();
            araba.renk = "Beyaz";
            araba.hiz = 200;
            araba.motor = 1249.34;
            araba.fiyat = 550000;
            araba.durum = 's';

            label1.Text = araba.renk;
            label2.Text = araba.hiz.ToString();
            label3.Text = araba.motor.ToString();
            label4.Text = araba.fiyat.ToString();
            label5.Text = araba.durum.ToString();
            pictureBox1.BackColor = Color.Bisque;

        }
    }
}
