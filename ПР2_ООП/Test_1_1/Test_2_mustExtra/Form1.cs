namespace Test_2_mustExtra
{
    public partial class Form1 : Form
    {
        public static int NOD(params int[] vals) // метод для нахождения наибольшего общего делителя (алгоритм Евклида)
        {
            // используя ключевое слово params, мы можем передавать неопределенное количество параметров
            int count = 0;
            int a = 0;
            foreach (int v in vals)
            {
                if (count == 0) // первый заход
                {
                    count++;
                    a = v;
                    continue;
                }

                int b = v; // каждый следующий элемент массива
                // привычный нам алгоритм Евклида
                if (a == 0)
                {
                    a = b;
                    continue;
                }
                while (b != 0)
                {
                    if (a > b) a -= b;
                    else b -= a;
                }
            }
            return a;
        }
        public void output_for_button() // метод даёт вывод после нажатия кнопки
        {
            string[] array = textBox1.Text.Split(" "); // данные через разделитель записываем в массив
            int[] conv_int_array;
            try // проверяем, вдруг введут не int
            {
                conv_int_array = Array.ConvertAll(array, int.Parse); // конвертируем данные массива в целочисленные
            }
            catch(FormatException) //ловим ошибку неверный формат
            {
                MessageBox.Show("Неверный формат, исправляй!");
                return;
            }
            if (conv_int_array.Length < 2) // недопускается ввод меньше 2х чисел
            {
                MessageBox.Show("Нужно ввести не менее двух");
                return;
            }
            label2.Text = NOD(conv_int_array).ToString(); // выводим в виде строки в label2

        }
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            output_for_button();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}