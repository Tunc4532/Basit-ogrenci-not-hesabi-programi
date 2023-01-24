using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OĞRWNCİ_NOT_HESABI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, s3,ort;
           s1=Convert.ToInt32(textBox1.Text);
            s2=Convert.ToInt32(textBox2.Text);
            s3=Convert.ToInt32(textBox3.Text);

            ort = (s1 + s2 + s3) / 3;
            if (ort<0)
            {
                listBox1.Items.Add("Geçersiz Not"+ "Ortalamanız: "+ort);
            }
            else if (ort<=39)
            {
                listBox1.Items.Add("FF" + " Ortalamanız: " + ort);
            }
            else if (ort <= 50)
            {
                listBox1.Items.Add("CC" + " Ortalamanız: " + ort);
            }
            else if (ort <= 75)
            {
                listBox1.Items.Add("BB" + " Ortalamanız: " + ort);
            }
            else if (ort <= 100)
            {
                listBox1.Items.Add("AA" + " Ortalamanız: " + ort);
            }
            else if (ort > 100)
            {
                listBox1.Items.Add("Geçersiz Not");
            }
        }
    }
}
