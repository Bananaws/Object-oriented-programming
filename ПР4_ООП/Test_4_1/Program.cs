using System.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Test_4_1
{
    /// <summary>
    /// Структура для представления комплексного числа
    /// </summary>
    struct Complex
    {
        public double im; // мнимая часть
        public double re; // действительная часть

        /// <summary> Метод представления комплексного числа в удобной форме</summary>
        /// <returns>String</returns>
        public override string ToString() // перегрузка ToString()
        {
            string result;
            if (im < 0) result = re +""+ im + "i";
            else result = re + "+" + im + "i";
            return result;
        }
        /// <summary>
        /// Метод для вычисления модуля комплексного числа
        /// </summary>
        public readonly double Module() // вычисление модуля комплексного числа
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
        public static bool operator == (Complex x, Complex y) //перегрузка оператора == (нельзя без !=)
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
        public static bool operator != (Complex x, Complex y) //перегрузка оператора != (нельзя без ==)
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
        public static Complex operator + (Complex x, Complex y)
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
        public static Complex operator - (Complex x, Complex y)
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
        public static Complex operator * (Complex x, Complex y)
        {
            y.im = y.re * x.im + y.im * x.re;
            y.re = y.re * x.re - y.im * x.im;
            return y;
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

    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1 + complex2;
            Console.WriteLine(complex1.ToString() + " + " + complex2.ToString() + " = " + result.ToString());

            result = complex1 * complex2;
            Console.WriteLine(complex1.ToString() + " * " + complex2.ToString() + " = " + result.ToString());

            result = complex1 - complex2;
            Console.WriteLine(complex1.ToString() + " - " + complex2.ToString() + " = " + result.ToString());

            if (complex1 == complex2) Console.WriteLine($"{complex1} == {complex2}"); 
            if (complex1 != complex2) Console.WriteLine($"{complex1} != {complex2}");
            double abs;
            abs = complex1.Module();
            Console.WriteLine("Модуль от " + complex1.ToString() + " = " + abs.ToString());
        }
    }
}