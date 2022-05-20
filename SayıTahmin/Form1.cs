using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayıTahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int sayi = 0, tahmin_sayısı = 0, puan = 1000;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            button1.Enabled = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tahmin;
            tahmin_sayısı++;
            if (tahmin_sayısı<=10)
            {
                tahmin = int.Parse(textBox1.Text);
                label6.Text = tahmin_sayısı.ToString();
                if (sayi<tahmin)
                {
                    label5.Text = "tahminini azaltınız";
                    puan = puan - 100;
                    label7.Text = puan.ToString();
                }
                else if (tahmin<sayi)
                {
                    label5.Text = "tahminini yükseltiniz";
                    puan = puan - 100;
                    label7.Text = puan.ToString();
                }
                else
                {
                
                    label5.Text = "tebrikler " +    label6.Text + " defada bildiniz "+ label7.Text+ "puan aldınız ";


                    button2.Enabled = true;
                    button1.Enabled = false;
                        
                }
                textBox1.Text = "";
            }
            else
            {
                textBox1.Enabled = false;
                MessageBox.Show("tahmin hakkınız kalmadı oyun katılacak");
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            Random r = new Random();
            sayi = r.Next(0,1000);
            label8.Text = sayi.ToString();
            label5.Text = "";
            label6.Text = "0";
            label7.Text = "1000";

               


        }
    }
}
