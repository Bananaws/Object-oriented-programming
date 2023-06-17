namespace Test_1
{
    public partial class Form1 : Form
    {
        public static int NOD(int a, int b) // Метод Евклида для двух переменных
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
                    label1.Text = "НОД = " + NOD(num1, num2).ToString(); // Вывод метода NOD в виде строки
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}