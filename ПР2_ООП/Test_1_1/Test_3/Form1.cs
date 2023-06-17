using System.Diagnostics;

namespace Test_3
{
    public partial class Form1 : Form
    {
        static public int FindGCDStein(out long time2, params int[] vals) // метод Штейна для НОД
        {
            time2 = 0;                         // таймер
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int count = 0;
            int u = 0;
            foreach (int val in vals)
            {
                if (count == 0) // первый заход
                {
                    count++;
                    u = val;
                    continue;
                }
                int k;
                int v = val;
                // Step 1.
                // gcd(0, v) = v, because everything divides zero, 
                // and v is the largest number that divides v. 
                // Similarly, gcd(u, 0) = u. gcd(0, 0) is not typically 
                // defined, but it is convenient to set gcd(0, 0) = 0.
                if (u == 0 || v == 0)
                {
                    sw.Stop();
                    time2 = sw.ElapsedTicks;
                    return u | v;
                }
                // Step 2.
                // if u and v are both even, then gcd(u, v) = 2•gcd(u/2, v/2), 
                // because 2 is a common divisor. 
                for (k = 0; ((u | v) & 1) == 0; ++k)
                {
                    u >>= 1;
                    v >>= 1;
                }
                // Step 3.
                // if u is even and v is odd, then gcd(u, v) = gcd(u/2, v), 
                // because 2 is not a common divisor. 
                // Similarly, if u is odd and v is even, 
                // then gcd(u, v) = gcd(u, v/2). 

                while ((u & 1) == 0)
                    u >>= 1;
                // Step 4.
                // if u and v are both odd, and u ≥ v, 
                // then gcd(u, v) = gcd((u − v)/2, v). 
                // If both are odd and u < v, then gcd(u, v) = gcd((v − u)/2, u). 
                // These are combinations of one step of the simple 
                // Euclidean algorithm, 
                // which uses subtraction at each step, and an application 
                // of step 3 above. 
                // The division by 2 results in an integer because the 
                // difference of two odd numbers is even.
                do
                {
                    while ((v & 1) == 0)  // Loop x
                        v >>= 1;
                    // Now u and v are both odd, so diff(u, v) is even.
                    //   Let u = min(u, v), v = diff(u, v)/2. 
                    if (u < v)
                    {
                        v -= u;
                    }
                    else
                    {
                        int diff = u - v;
                        u = v;
                        v = diff;
                    }
                    v >>= 1;
                    // Step 5.
                    // Repeat steps 3–4 until u = v, or (one more step) 
                    // until u = 0.
                    // In either case, the result is (2^k) * v, where k is 
                    // the number of common factors of 2 found in step 2. 
                } while (v != 0);
                u <<= k;
            }
            sw.Stop();
            time2 = sw.ElapsedTicks;
            return u;
        }

        public static int NOD(out long time1, params int[] vals) // метод для нахождения наибольшего общего делителя (алгоритм Евклида)
        {
            // используя ключевое слово params, мы можем передавать неопределенное количество параметров
            time1 = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
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
            sw.Stop();
            time1 = sw.ElapsedTicks;
            return a;
        }
        public void output_for_button1() // метод даёт вывод после нажатия кнопки
        {
            string[] array = textBox1.Text.Split(" "); // данные через разделитель записываем в массив
            int[] conv_int_array;
            try // проверяем, вдруг введут не int
            {
                conv_int_array = Array.ConvertAll(array, int.Parse); // конвертируем данные массива в целочисленные
            }
            catch (FormatException) //ловим ошибку неверный формат
            {
                MessageBox.Show("Неверный формат, исправляй!");
                return;
            }
            if (conv_int_array.Length < 2) // недопускается ввод меньше 2х чисел
            {
                MessageBox.Show("Нужно ввести не менее двух");
                return;
            }
            label1.Text = NOD(out long time1, conv_int_array).ToString(); // выводим в виде строки в label1
            label2.Text = "Время:" + time1;
            time1 = 0;
        }
        public void output_for_button2()
        {
            string[] array = textBox1.Text.Split(" "); // данные через разделитель записываем в массив
            int[] conv_int_array;
            try // проверяем, вдруг введут не int
            {
                conv_int_array = Array.ConvertAll(array, int.Parse); // конвертируем данные массива в целочисленные
            }
            catch (FormatException) //ловим ошибку неверный формат
            {
                MessageBox.Show("Неверный формат, исправляй!");
                return;
            }
            if (conv_int_array.Length < 2) // недопускается ввод меньше 2х чисел
            {
                MessageBox.Show("Нужно ввести не менее двух");
                return;
            }
            label3.Text = FindGCDStein(out long time2, conv_int_array).ToString(); // выводим в виде строки в label3
            label4.Text = "Время:" + time2;
            time2 = 0;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            output_for_button1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            output_for_button2();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}