using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double valueDollar = 36.49;
            double valueEuro = 38.74;
            double valuePound = 44.93;

            label6.Text = valueDollar.ToString();
            label7.Text = valueEuro.ToString();
            label8.Text = valuePound.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);

            double x;

            if (radioButton1.Checked)
            {
                x = a / double.Parse(label6.Text);
                pictureBox1.Image = Image.FromFile("C:\\Documents\\4 курс\\1 семестр\\Інструментальні засоби візуального програмування\\lab_6.1\\dollar.jpg");
            }
            else if (radioButton2.Checked)
            {
                x = a / double.Parse(label7.Text);
                pictureBox1.Image = Image.FromFile("C:\\Documents\\4 курс\\1 семестр\\Інструментальні засоби візуального програмування\\lab_6.1\\euro.jpg");
            }
            else
            {
                x = a / double.Parse(label8.Text);
                pictureBox1.Image = Image.FromFile("C:\\Documents\\4 курс\\1 семестр\\Інструментальні засоби візуального програмування\\lab_6.1\\pound.jpg");
            }

            x = Math.Round(x, 2);
            label9.Text = x.ToString();
            checkBox1.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox2.Visible = true;
            else
                pictureBox2.Visible = false;

            if (radioButton1.Checked)
            {
                pictureBox2.Image = Image.FromFile("C:\\Documents\\4 курс\\1 семестр\\Інструментальні засоби візуального програмування\\lab_6.1\\check2.jpg");
            }
            else if (radioButton2.Checked)
            {
                pictureBox2.Image = Image.FromFile("C:\\Documents\\4 курс\\1 семестр\\Інструментальні засоби візуального програмування\\lab_6.1\\check2.jpg");
            }
            else
            {
                pictureBox2.Image = Image.FromFile("C:\\Documents\\4 курс\\1 семестр\\Інструментальні засоби візуального програмування\\lab_6.1\\check3.jpg");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                checkBox1.Checked = true;
                pictureBox2.Image = Image.FromFile("C:\\Documents\\4 курс\\1 семестр\\Інструментальні засоби візуального програмування\\lab_6.1\\check1.jpg");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                checkBox1.Checked = true;
                pictureBox2.Image = Image.FromFile("C:\\Documents\\4 курс\\1 семестр\\Інструментальні засоби візуального програмування\\lab_6.1\\check2.jpg");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                checkBox1.Checked = true;
                pictureBox2.Image = Image.FromFile("C:\\Documents\\4 курс\\1 семестр\\Інструментальні засоби візуального програмування\\lab_6.1\\check3.jpg");
            }
        }
    }
}