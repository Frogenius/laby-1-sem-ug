using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            if (x==2)
            {
                label1.Text = "Liczba " + x + " jest liczbą pierwszą";
            }
            else if (x % 2 == 0)
            {
                label1.Text = "Liczba " + x + "nie jest liczbą pierwrzą";
            }
            else
            {
                bool pierwsza = true;
                for (int i = 3; i < Math.Sqrt(x)+1; i+=2)
                {
                    if (x % i == 0)
                    {
                        pierwsza = false;
                        label1.Text = "Liczba " + x + "nie jest liczba pierwszą";
                        break;
                    }
                }
                
                if (pierwsza)
                {
                    label1.Text = "Liczba " + x + " jest liczbą pierwszą";

                }
            }
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
