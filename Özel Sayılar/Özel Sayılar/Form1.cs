using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Özel_Sayılar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayi;
            int sayac = 0;
            int carp;
            int sonuc;

            int baslangıc = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);
   
            for (int i = baslangıc; i <= bitis; i++)
            {
                sayi = i * i;

                carp = (sayi * 2) - 1;
                for (int j = 0; j <= carp; j++)
                {
                    sonuc = j * j;
                    if(carp == sonuc)
                    {
                        listBox1.Items.Add((sayac+1) + ". Özel Sayı : " + i);
                        sayac++;
                    }
                }
            }
            label4.Text = "\n" + baslangıc + " İle " + bitis + " Arasında Toplam " + sayac + " Tane Özel Sayı Vardır.";
            label1.Text = "           " + baslangıc + " İle " + bitis + " Arasındaki Özel Sayılar ";
        }
    }
}
