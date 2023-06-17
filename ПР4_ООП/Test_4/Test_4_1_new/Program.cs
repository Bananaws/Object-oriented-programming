using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_4_1_new
{
    /// <summary>
    /// Структура для представления комплексного числа
    /// </summary>
    public struct Complex
    {
        public double im; // мнимая часть
        public double re; // действительная часть

        /// <summary> Метод представления комплексного числа в удобной форме</summary>
        /// <returns>String</returns>
        public override string ToString() // переопределение ToString()
        {
            string result;
            if (im < 0) result = re + "" + im + "i";
            else result = re + "+" + im + "i";
            return result;
        }
        /// <summary>
        /// Метод для вычисления модуля комплексного числа
        /// </summary>
        public double Module() // вычисление модуля комплексного числа
        {
            Complex x;
            double z;
            x.re = re * re;
            x.im = im * im;
            z = Math.Sqrt(x.re + x.im);
            return z;
        }
        /// <summary>
        /// Переопределёный оператор == для сравнения комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>true or false</returns>
        public static bool operator ==(Complex x, Complex y) //перегрузка оператора == (нельзя без !=)
        {
            if (x.re != y.re && y.im != x.im) return false;
            else return true;
        }
        /// <summary>
        /// Переопределёный оператор != для сравнения комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>true or false</returns>
        public static bool operator !=(Complex x, Complex y) //перегрузка оператора != (нельзя без ==)
        {
            if (x.re == y.re && y.im == x.im) return false;
            else return true;
        }
        /// <summary>
        /// Переопределение оператора + для комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>x+y</returns>
        public static Complex operator +(Complex x, Complex y)
        {
            y.im = y.im + x.im;
            y.re = y.re + x.re;
            return y;
        }
        /// <summary>
        /// Переопределение оператора - для комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>x-y</returns>
        public static Complex operator -(Complex x, Complex y)
        {
            x.im = x.im - y.im;
            x.re = x.re - y.re;
            return x;
        }
        /// <summary>
        /// Переопределение оператора * для комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>x*y</returns>
        public static Complex operator *(Complex x, Complex y)
        {
            Complex z = new Complex();
            z.re = x.re * y.re - x.im * y.im;
            z.im = x.re * y.im + y.re * x.im;
            return z;
        }

        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
