using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)   
        {
            double vize, final, yuzde, ort;
            vize = Convert.ToDouble(textBox1.Text);
            final = Convert.ToDouble(textBox2.Text);
            yuzde = Convert.ToDouble(textBox3.Text);
            ort = (vize * (yuzde / 100) + (final * (1 - (yuzde / 100))));
            label7.Text = ort.ToString();

            if (ort >= 50)
            {
                MessageBox.Show("Tebrikler Geçtiniz!");
            }
            else
            {
                MessageBox.Show("Bu Dersten Kaldınız!");
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Not Hesaplama";
            Text = "Not Hesaplama";
        }
    }
}
