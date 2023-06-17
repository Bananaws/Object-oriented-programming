namespace Test_2
{
    public partial class Form1 : Form
    {
        // метод Евклида:
        public static int NOD(int a, int b)// перегруженный метод NOD c 2 переменными
        {
            if (a == 0) return b;
            while (b != 0)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
        public static int NOD(int a, int b, int c) // перегруженный метод NOD с 3 переменными
        {
            int d = NOD(a, b);
            int e = NOD(d, c);
            return e;
        }
        public static int NOD(int a, int b, int c, int d) // перегруженный метод NOD с 4 переменными
        { 
            int three = NOD(a, b, c);
            int e = NOD(three, d);
            return e;
        }
        public static int NOD(int a, int b, int c, int d, int e) // перегруженный метод NOD с 5 переменными
    {
            int four = NOD(a, b, c, d);
            int r = NOD(four, e);
            return r;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(textBox1.Text, out var num1))) // Проверка ввода первого числа
            {
                MessageBox.Show("Неверно, повторите ввод");
                return;
            }
            else
            {
                if (!(int.TryParse(textBox2.Text, out var num2))) // Проверка ввода второго числа
                {
                    MessageBox.Show("Неверно, повторите ввод");
                    return;
                }
                else
                {
                    label1.Text = NOD(num1, num2).ToString(); // Вывод метода NOD в виде строки
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(textBox1.Text, out var num1))) // Проверка ввода первого числа
            {
                MessageBox.Show("Неверно, повторите ввод");
                return;
            }
            else
            {
                if (!(int.TryParse(textBox2.Text, out var num2))) // Проверка ввода второго числа
                {
                    MessageBox.Show("Неверно, повторите ввод");
                    return;
                }
                else
                {
                    if (!(int.TryParse(textBox3.Text, out var num3))) // Проверка ввода первого числа
                    {
                        MessageBox.Show("Неверно, повторите ввод");
                        return;
                    }
                    else
                    {
                        label1.Text = NOD(num1, num2, num3).ToString(); // Вывод метода NOD в виде строки
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(textBox1.Text, out var num1))) // Проверка ввода первого числа
            {
                MessageBox.Show("Неверно, повторите ввод");
                return;
            }
            else
            {
                if (!(int.TryParse(textBox2.Text, out var num2))) // Проверка ввода второго числа
                {
                    MessageBox.Show("Неверно, повторите ввод");
                    return;
                }
                else
                {
                    if (!(int.TryParse(textBox3.Text, out var num3))) // Проверка ввода первого числа
                    {
                        MessageBox.Show("Неверно, повторите ввод");
                        return;
                    }
                    else
                    {
                        if (!(int.TryParse(textBox4.Text, out var num4))) // Проверка ввода первого числа
                        {
                            MessageBox.Show("Неверно, повторите ввод");
                            return;
                        }
                        else
                        {
                            label1.Text = NOD(num1, num2, num3, num4).ToString(); // Вывод метода NOD в виде строки
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(textBox1.Text, out var num1))) // Проверка ввода первого числа
            {
                MessageBox.Show("Неверно, повторите ввод");
                return;
            }
            else
            {
                if (!(int.TryParse(textBox2.Text, out var num2))) // Проверка ввода второго числа
                {
                    MessageBox.Show("Неверно, повторите ввод");
                    return;
                }
                else
                {
                    if (!(int.TryParse(textBox3.Text, out var num3))) // Проверка ввода первого числа
                    {
                        MessageBox.Show("Неверно, повторите ввод");
                        return;
                    }
                    else
                    {
                        if (!(int.TryParse(textBox4.Text, out var num4))) // Проверка ввода первого числа
                        {
                            MessageBox.Show("Неверно, повторите ввод");
                            return;
                        }
                        else
                        {
                            if (!(int.TryParse(textBox5.Text, out var num5))) // Проверка ввода первого числа
                            {
                                MessageBox.Show("Неверно, повторите ввод");
                                return;
                            }
                            else
                            {
                                label1.Text = NOD(num1, num2, num3, num4, num5).ToString(); // Вывод метода NOD в виде строки
                            }
                        }
                    }
                }
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}