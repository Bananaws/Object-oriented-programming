using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test_4_1_new
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Complex comp1 = new Complex();
            string[] str1 = textBox1.Text.Split('+');
            double re1 = double.Parse(str1[0]);
            string b = str1[1];
            double im1 = double.Parse(b.Trim('i'));
            comp1.re = re1;
            comp1.im = im1;
            Complex comp2 = new Complex();
            string[] str2 = textBox2.Text.Split('+');
            double re2 = double.Parse(str2[0]);
            string c = str2[1];
            double im2 = double.Parse(c.Trim('i'));
            comp2.re = re2;
            comp2.im = im2;
            Complex comp3 = comp1 + comp2;
            textBox3.Text = comp3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Complex comp1 = new Complex();
            string[] str1 = textBox1.Text.Split('+');
            double re1 = double.Parse(str1[0]);
            string b = str1[1];
            double im1 = double.Parse(b.Trim('i'));
            comp1.re = re1;
            comp1.im = im1;
            Complex comp2 = new Complex();
            string[] str2 = textBox2.Text.Split('+');
            double re2 = double.Parse(str2[0]);
            string c = str2[1];
            double im2 = double.Parse(c.Trim('i'));
            comp2.re = re2;
            comp2.im = im2;
            Complex comp3 = comp1 - comp2;
            textBox3.Text = comp3.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Complex comp1 = new Complex();
            string[] str1 = textBox1.Text.Split('+');
            double re1 = double.Parse(str1[0]);
            string b = str1[1];
            double im1 = double.Parse(b.Trim('i'));
            comp1.re = re1;
            comp1.im = im1;
            Complex comp2 = new Complex();
            string[] str2 = textBox2.Text.Split('+');
            double re2 = double.Parse(str2[0]);
            string c = str2[1];
            double im2 = double.Parse(c.Trim('i'));
            comp2.re = re2;
            comp2.im = im2;
            Complex comp3 = comp1 * comp2;
            textBox3.Text = comp3.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Complex comp1 = new Complex();
            string[] str1 = textBox1.Text.Split('+');
            double re1 = double.Parse(str1[0]);
            string b = str1[1];
            double im1 = double.Parse(b.Trim('i'));
            comp1.re = re1;
            comp1.im = im1;
            Complex comp2 = new Complex();
            string[] str2 = textBox2.Text.Split('+');
            double re2 = double.Parse(str2[0]);
            string c = str2[1];
            double im2 = double.Parse(c.Trim('i'));
            comp2.re = re2;
            comp2.im = im2;
            bool comp3 = comp1 == comp2;
            textBox3.Text = comp3.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Complex comp1 = new Complex();
            string[] str1 = textBox1.Text.Split('+');
            double re1 = double.Parse(str1[0]);
            string b = str1[1];
            double im1 = double.Parse(b.Trim('i'));
            comp1.re = re1;
            comp1.im = im1;
            Complex comp2 = new Complex();
            string[] str2 = textBox2.Text.Split('+');
            double re2 = double.Parse(str2[0]);
            string c = str2[1];
            double im2 = double.Parse(c.Trim('i'));
            comp2.re = re2;
            comp2.im = im2;
            bool comp3 = comp1 != comp2;
            textBox3.Text = comp3.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Complex comp1 = new Complex();
            string[] str1 = textBox4.Text.Split('+');
            double re1 = double.Parse(str1[0]);
            string b = str1[1];
            double im1 = double.Parse(b.Trim('i'));
            comp1.re = re1;
            comp1.im = im1;
            textBox5.Text = comp1.Module().ToString();
        }
    }
}
