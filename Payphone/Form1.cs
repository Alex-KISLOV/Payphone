using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payphone
{
    public partial class Form1 : Form
    {
        int x;
        public int m, s, ms;
        public double karSUMM = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)   // Трубка
        {
            if (Convert.ToString(textBox2.Text) == "Трубка")
            { textBox2.Text = "Карта"; }
            if (checkBox1.Checked == false)
            {
                System.Windows.Forms.Application.Restart();
                System.Environment.Exit(1);
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)   // Карта
        {
            if (Convert.ToString(textBox2.Text) == "Карта")
            {
                Random rnd = new Random();
                int f = rnd.Next(1,2);
                if (f == 2)
                {
                    textBox2.Text = "Занято";
                }
                if (f == 1)
                {
                    textBox2.Text = "Данные";
                }
            }
            if (Convert.ToString(textBox2.Text) == "Данные")
            {
                textBox2.Text = "Номер";
            }
            if ((checkBox2.Checked == false) || (Convert.ToString(textBox2.Text) == "Занято"))
            {
                System.Windows.Forms.Application.Restart();
                System.Environment.Exit(1);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a1 = Convert.ToString(1);
            textBox1.Text = textBox1.Text + a1;
            x++;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a2 = Convert.ToString(2);
            textBox1.Text = textBox1.Text + a2;
            x++;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a3 = Convert.ToString(3);
            textBox1.Text = textBox1.Text + a3;
            x++;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a4 = Convert.ToString(4);
            textBox1.Text = textBox1.Text + a4;
            x++;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string a5 = Convert.ToString(5);
            textBox1.Text = textBox1.Text + a5;
            x++;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string a6 = Convert.ToString(6);
            textBox1.Text = textBox1.Text + a6;
            x++;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string a7 = Convert.ToString(7);
            textBox1.Text = textBox1.Text + a7;
            x++;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string a8 = Convert.ToString(8);
            textBox1.Text = textBox1.Text + a8;
            x++;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string a9 = Convert.ToString(9);
            textBox1.Text = textBox1.Text + a9;
            x++;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string a0 = Convert.ToString(0);
            textBox1.Text = textBox1.Text + a0;
            x++;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 7;
        }

        private void timer2_Tick(object sender, EventArgs e)    // Таймер за снятие денег
        {
            karSUMM -= 0.25;
            string a9 = Convert.ToString(karSUMM);
            label2.Text = "";
            label2.Text = label2.Text + a9;
            if (karSUMM == 0)
            {
                System.Windows.Forms.Application.Restart();
                System.Environment.Exit(1);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)    // Таймер
        {
            ms += 1;
            if (ms == 60)
            {
                ms = 0;
                s += 1;
            }
            if (s == 60)
            {
                s = 0;
                m += 1;
            }
            label1.Text = m.ToString() + ":" + s.ToString() + ":" + ms.ToString();
        }

        private void button11_Click(object sender, EventArgs e)     // Кнопка вызова
        {
            if (x == 7)
            {
                textBox2.Text = "Вызов";
            }
            if (x != 7)
            {
                textBox2.Text = "Ошибка";

            }
            if (Convert.ToString(textBox2.Text) == "Вызов")
            {
                Random rnd = new Random();
                int f = rnd.Next(1,2);
                if (f == 2)
                {
                    textBox1.Text = "Занято";
                }
                if (f == 1)
                {
                    textBox1.Text = "Данные";
                    timer1.Enabled = true;
                    timer2.Enabled = true;
                    m = 0; s = 0; ms = 0;
                    label1.Text = "0:0:0";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
