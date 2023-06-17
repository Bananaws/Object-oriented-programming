using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Task_2
{
    /// <summary>
    /// Start
    /// </summary>
    public partial class Form1 : Form
    {
        // Параметры для итераций
        long iterator = 0;
        decimal numberDecimaliter;
        decimal deltaiter;
        decimal guessiter;
        decimal resultiter;
        /// <summary>
        /// Метод для поддержки конструктора
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Read a line of data entered by the user.
        /// Format the data and display the results in the 
        /// formattedText TextBlock control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) // Кнопка Посчитать
        {
            // Math.Sqrt
            bool res1 = double.TryParse(textBox1.Text, out var num1); // проверяем double ли
            double numberDouble;
            if (res1 == true)
            {
                numberDouble = num1;
                if (numberDouble >= 0) // проверка на положительное число
                {
                    double squareRoot = Math.Sqrt(numberDouble); // находим корень
                    label1.Text = squareRoot.ToString() + "   Math.Sqrt"; // Выводим
                }
                else
                {
                    MessageBox.Show("Ошибка, введите положительное число");
                    return;
                }
            }
            else 
            {
                MessageBox.Show("Ошибка, нужно ввести double.");
                return;
            }

            // Newton's method
            bool res2 = decimal.TryParse(textBox1.Text, out var num2); // проверяем decimal ли
            decimal numberDecimal;
            if (res2 == true)
            {

                numberDecimal = num2;
                if (numberDecimal == 0) // сразу выписываем нуль
                {
                    label2.Text = numberDecimal.ToString() + "   Newton";
                    return;
                }
                if (numberDecimal > 0) // если положительное и не нуль
                {
                    decimal delta = Convert.ToDecimal(Math.Pow(10, -28)); // Для проверки точности (наименьшее значение)
                    decimal guess = (decimal)Math.Sqrt((double)numberDecimal / 2);
                    decimal result = ((numberDecimal / guess) + guess) / 2; // значение каждой итерации
                    while (Math.Abs(result - guess) > delta) // пока можно, выполняем
                    {
                        guess = result;
                        result = ((numberDecimal / guess) + guess) / 2;
                    }
                    label2.Text = result.ToString() + "   Newton"; // Выводим
                }
                else
                {
                    MessageBox.Show("Ошибка, введите положительное число");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Ошибка, нужно ввести decimal.");
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Кнопка, в которой производятся вычисления метода Newton
        /// с прослеживанием каждого хода (итерации)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e) // Кнопка Итерация
        {
            // Подготовка (проверка числа, 0 или отрицательное)
            if (iterator == 0)
            {
                bool res = decimal.TryParse(textBox1.Text, out var num);
                if (res == true)
                {
                    if (num == 0) // проверяем не нуль ли
                    {
                        label2.Text = num.ToString() + "   Newton";
                        label3.Text = "Кол-во итераций: " + num.ToString();
                        label4.Text = "Погрешность: " + num.ToString();
                        label5.Text = "Корень при этой итерации: " + num.ToString();
                        iterator = 0;
                        return;
                    }
                    if (num > 0) // положительное ли
                    {
                        // операции из метода Newton
                        numberDecimaliter = num;
                        deltaiter = Convert.ToDecimal(Math.Pow(10, -28));
                        guessiter = (decimal)numberDecimaliter / 2;
                        // string * 1.6
                        resultiter = ((numberDecimaliter / guessiter) + guessiter) / 2;
                    }
                    else
                    {
                        MessageBox.Show("Ошибка, введите положительное число");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка, нужно ввести decimal.");
                    return;
                }
            }

                // Итерации (срабатывает по нажатию на кнопку)
                if (Math.Abs(resultiter - guessiter) > deltaiter)
                {
                    // Высчитываем и заполняем
                    guessiter = resultiter;
                    resultiter = ((numberDecimaliter / guessiter) + guessiter) / 2;
                    iterator++;
                    label3.Text = "Кол-во итераций: " + iterator.ToString();
                    label4.Text = "Погрешность: " + Math.Abs(resultiter - guessiter).ToString();
                    label5.Text = "Корень при этой итерации: " + resultiter.ToString();
                }
                else // конец итераций
                {
                    label2.Text = resultiter.ToString() + "   Newton"; // выведем итоговое число
                    iterator = 0;
                    resultiter = 0;
                    guessiter = 0;
                    return;
                }
                
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
