using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Get_number() // Система счисления
        {
            int number;
            if (!(int.TryParse(textBox2.Text, out number))) // парсим входное значение
            {
                MessageBox.Show($"Данные были введены неверно, по умолчанию система счисления 2");
                textBox2.Text = "2";
                return 2;
            }
            else
            {
                if (number > 1 && number < 17) return number; // проверка на поддерживаемую систему счисления
                else 
                {
                    MessageBox.Show($"Данные были введены неверно, по умолчанию система счисления 2");
                    textBox2.Text = "2";
                    return 2;
                }
            }
        }
        string Conv_to_alphabet(int num) // Перевод чисел [10;16] в A - F 
        {
            string s = "";
            if (num < 10) return num.ToString(); // если число меньше 10, то выводим входное число.
            else // иначе выводим символы в виде строки.
            {
                if (num == 10) s = "A";
                if (num == 11) s = "B";
                if (num == 12) s = "C";
                if (num == 13) s = "D";
                if (num == 14) s = "E";
                if (num == 15) s = "F";
                return s;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int reminder = 0; // остаток от деления
            StringBuilder str = new StringBuilder(); // изменяемая строка символов
            if (!(int.TryParse(textBox1.Text, out var number)))
            {
                MessageBox.Show($"Введите тип int");
                return;
            }
            else
            {
                if (number >= 0)
                {
                    int num1 = number;
                    string strin;
                    int num2 = Get_number(); // берём выбранную систему счисления
                    do // сначало выполняет, потом проверяет условие
                    {
                        reminder = num1 % num2; // сохраним остаток
                        num1 /= num2;
                        strin = Conv_to_alphabet(reminder);
                        str.Insert(0, strin); // помещаем в строку
                    }while (num1 > 0);
                    textBox3.Text = str.ToString(); // выводим результат в виде строки
                }
                else
                {
                    MessageBox.Show($"Введите положительное число");
                    return;
                }
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
