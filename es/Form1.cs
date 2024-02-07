using Frazioni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Fraction f1 = Fraction.Parse(textBox1.Text);
            textBox1.Text = f1.ToString();
            Fraction f2 = Fraction.Parse(textBox2.Text);
            textBox2.Text = f2.ToString();
            Fraction f3 = f1.Somma(f2);
            label1.Text = f3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fraction f = Fraction.Parse(textBox3.Text); 
            listBox1.Items.Add(f);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fraction somma = new Fraction(0, 1);
            foreach (Fraction f in listBox1.Items) 
            {
              somma = somma.Somma(f);
            }
            listBox1.Text= somma.ToString();    
        }
    }
}
