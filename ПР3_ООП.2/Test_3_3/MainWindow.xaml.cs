using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test_3_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            int num1 = 2147483647;
            int umn = 2;
            try
            {
                checked // проверка на ошибку
                {
                    num1 *= umn;
                }
                
            }
            catch(OverflowException e1) // поймана ошибка переполнения
            {
                MessageBox.Show(e1.Message.ToString());
            }
            textBox1.Text = num1.ToString(); // Вывод: 2147483647

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            int num2 = 2147483647;
            int umn = 2;
            try
            {
                unchecked // игнорирование ошибок
                {
                    num2 *= umn;
                }

            }
            catch (OverflowException e1) // не будет поймана ошибка
            {
                MessageBox.Show(e1.Message.ToString());
            }
            textBox2.Text = num2.ToString(); // Вывод: -2 (произошло переполнение)
        }
    }
}
