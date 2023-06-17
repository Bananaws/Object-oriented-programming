using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Task_1._7
{
    public partial class Form1 : Form
    {
        private void Text_check() // Метод для проверки числа на соответствие нужного формата
        {
            int input;
            double input2;
            bool res = double.TryParse(textBox1.Text, out input2); // Преобразуем то, что ввели, в число double
            if (res == true) // Если преобразование прошло успешно
            {
                input = (int)input2; // Делаем явное преобразование
                if (input - input2 == 0) // Если не теряется дробная часть, то выводим число
                    MessageBox.Show("Ваше число не соответсвует нужному формату");
                else
                    MessageBox.Show($"Вы верно ввели вещественное число: {input2}");
  
            }
            else
                MessageBox.Show("Ваше число не соответсвует нужному формату");
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e) // Поле, куда мы вписываем
        {
            
        }
        private void button1_Click(object sender, EventArgs e) // Кнопка ("ПУСК"), после нажатия которой сработает метод
        {
            Text_check(); // Задействуем наш метод
        }
    }
}