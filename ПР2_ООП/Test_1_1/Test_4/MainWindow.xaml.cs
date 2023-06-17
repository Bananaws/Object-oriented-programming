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

namespace Test_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double[,] matrix1 = new double[2, 2];
        double[,] matrix2 = new double[2, 2];
        double[,] result = new double[2, 2];

        public MainWindow()
        {
            InitializeComponent();
            // Задаём комбобоксам возможные значения
            m1Col.Items.Add(new ComboBoxItem() { Content = "1" });
            m1Col.Items.Add(new ComboBoxItem() { Content = "2" });
            m1Col.Items.Add(new ComboBoxItem() { Content = "3" });
            m1Col.Items.Add(new ComboBoxItem() { Content = "4" });
            m1Col.Items.Add(new ComboBoxItem() { Content = "5" });
            m1Col.Items.Add(new ComboBoxItem() { Content = "10" });
            m1Col.Items.Add(new ComboBoxItem() { Content = "50" });

            m1Row.Items.Add(new ComboBoxItem() { Content = "1" });
            m1Row.Items.Add(new ComboBoxItem() { Content = "2" });
            m1Row.Items.Add(new ComboBoxItem() { Content = "3" });
            m1Row.Items.Add(new ComboBoxItem() { Content = "4" });
            m1Row.Items.Add(new ComboBoxItem() { Content = "5" });
            m1Row.Items.Add(new ComboBoxItem() { Content = "10" });
            m1Row.Items.Add(new ComboBoxItem() { Content = "50" });

            m2Col.Items.Add(new ComboBoxItem() { Content = "1" });
            m2Col.Items.Add(new ComboBoxItem() { Content = "2" });
            m2Col.Items.Add(new ComboBoxItem() { Content = "3" });
            m2Col.Items.Add(new ComboBoxItem() { Content = "4" });
            m2Col.Items.Add(new ComboBoxItem() { Content = "5" });
            m2Col.Items.Add(new ComboBoxItem() { Content = "10" });
            m2Col.Items.Add(new ComboBoxItem() { Content = "50" });

            m2Row.Items.Add(new ComboBoxItem() { Content = "1" });
            m2Row.Items.Add(new ComboBoxItem() { Content = "2" });
            m2Row.Items.Add(new ComboBoxItem() { Content = "3" });
            m2Row.Items.Add(new ComboBoxItem() { Content = "4" });
            m2Row.Items.Add(new ComboBoxItem() { Content = "5" });
            m2Row.Items.Add(new ComboBoxItem() { Content = "10" });
            m2Row.Items.Add(new ComboBoxItem() { Content = "50" });
        }

        private double[,] getRandomValuesFromGrid(Grid grid, double[,] matrix) // создание и рандомное заполнение матриц
        {
            int columns = grid.ColumnDefinitions.Count;
            int rows = grid.RowDefinitions.Count;
            // Iterate over cells in Grid, copying to matrix array
            for (int c = 0; c < grid.Children.Count; c++)
            {
                TextBox t = (TextBox)grid.Children[c];
                Random rnd = new Random();
                int row = Grid.GetRow(t);
                int column = Grid.GetColumn(t);
                matrix[row, column] = Math.Round(rnd.NextDouble(), 1);
            }
            return matrix;
        }
        private double[,] getValuesFromGrid(Grid grid, double[,] matrix) // создание матриц
        {
            int columns = grid.ColumnDefinitions.Count;
            int rows = grid.RowDefinitions.Count;
            // Iterate over cells in Grid, copying to matrix array
            for (int c = 0; c < grid.Children.Count; c++)
            {
                TextBox t = (TextBox)grid.Children[c];
                //Random rnd = new Random();
                int row = Grid.GetRow(t);
                int column = Grid.GetColumn(t);
                if (!(double.TryParse(t.Text, out var n))) // Проверка ввода первого числа
                {
                    MessageBox.Show("В матрице не число, повторите ввод");
                    break;
                }
                else
                {
                    matrix[row, column] = double.Parse(t.Text);
                }
                
            }
            return matrix;
        }
        private void initializeGrid(Grid grid, double[,] matrix) // инициализирование матриц
        {
            if (grid != null)
            {
                // Reset the grid before doing anything
                grid.Children.Clear();
                grid.ColumnDefinitions.Clear();
                grid.RowDefinitions.Clear();
                // Get the dimensions
                int rows = matrix.GetLength(0);
                int columns = matrix.GetLength(1);
                // Add the correct number of coumns to the grid
                for (int x = 0; x < columns; x++)
                {
                    grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(40, GridUnitType.Pixel), });
                }
                for (int y = 0; y < rows; y++)
                {
                    // GridUnitType.Star - The value is expressed as a weighted proportion of available space
                    grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(40, GridUnitType.Pixel), });
                }
                // Fill each cell of the grid with an editable TextBox containing the value from the matrix 
                for (int x = 0; x < columns; x++)
                {
                    for (int y = 0; y < rows; y++)
                    {
                        double cell = Math.Round(matrix[y, x], 2);
                        TextBox t = new TextBox();
                        t.Text = cell.ToString();
                        t.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                        t.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
                        t.SetValue(Grid.RowProperty, y);
                        t.SetValue(Grid.ColumnProperty, x);
                        grid.Children.Add(t);
                    }
                }
            }
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            initializeGrid(Matrix1, matrix1);
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            initializeGrid(Matrix2, matrix2);
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
                matrix1 = getValuesFromGrid(Matrix1, matrix1);
                matrix2 = getValuesFromGrid(Matrix2, matrix2);
                result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
                int m1columns_m2rows, m1rows, m2columns;
                m1columns_m2rows = matrix1.GetLength(1);
                m1rows = matrix1.GetLength(0);
                m2columns = matrix2.GetLength(1);
                for (int row = 0; row < m1rows; row++)
                {
                    try
                    {
                        for (int column = 0; column < m2columns; column++)
                        {
                            double accumulator = 0;
                            for (int cell = 0; cell < m1columns_m2rows; cell++)
                            {
                                accumulator += matrix1[row, cell] * matrix2[cell, column];
                            }
                            result[row, column] = accumulator;
                        }
                    }
                    catch(System.IndexOutOfRangeException)
                    {
                        MessageBox.Show("Ошибка умножений матриц: разные значения у col1 и row2");
                        return;
                    }  
                }
            initializeGrid(Result_Matrix, result);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            matrix1 = getRandomValuesFromGrid(Matrix1, matrix1);
            matrix2 = getRandomValuesFromGrid(Matrix2, matrix2);
            result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
            int m1columns_m2rows, m1rows, m2columns;
            m1columns_m2rows = matrix1.GetLength(1);
            m1rows = matrix1.GetLength(0);
            m2columns = matrix2.GetLength(1);
            for (int row = 0; row < m1rows; row++)
            {
                try
                {
                    for (int column = 0; column < m2columns; column++)
                    {
                        double accumulator = 0;
                        for (int cell = 0; cell < m1columns_m2rows; cell++)
                        {
                            accumulator += matrix1[row, cell] * matrix2[cell, column];
                        }
                        result[row, column] = accumulator;
                    }
                }
                catch (System.IndexOutOfRangeException)
                {
                    MessageBox.Show("Ошибка умножений матриц: разные значения у col1 и row2");
                    return;
                }
            }
            initializeGrid(Matrix1, matrix1);
            initializeGrid(Matrix2, matrix2);
            initializeGrid(Result_Matrix, result);

        }
        private void m1Col_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string? m1col = ((ComboBoxItem)(((ComboBox)sender).SelectedItem)).Content.ToString();
            if (!(int.TryParse(m1col, out var m1colum))) // Проверка ввода числа
            {
                MessageBox.Show("Неверно, повторите ввод");
                return;
            }
            matrix1 = new double[matrix1.GetLength(0), m1colum];
        }

        private void m1Row_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string? m1row = ((ComboBoxItem)(((ComboBox)sender).SelectedItem)).Content.ToString();
            if (!(int.TryParse(m1row, out var m1rows))) // Проверка ввода числа
            {
                MessageBox.Show("Неверно, повторите ввод");
                return;
            }
            matrix1 = new double[m1rows, matrix1.GetLength(1)];
        }

        private void m2Col_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string? m2col = ((ComboBoxItem)(((ComboBox)sender).SelectedItem)).Content.ToString();
            if (!(int.TryParse(m2col, out var m2colum))) // Проверка ввода числа
            {
                MessageBox.Show("Неверно, повторите ввод");
                return;
            }
            matrix2 = new double[matrix2.GetLength(0), m2colum];

        }
        private void m2Row_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string? m2row = ((ComboBoxItem)(((ComboBox)sender).SelectedItem)).Content.ToString();
            if (!(int.TryParse(m2row, out var m2rows))) // Проверка ввода числа
            {
                MessageBox.Show("Неверно, повторите ввод");
                return;
            }
            matrix2 = new double[m2rows, matrix2.GetLength(1)];
        }


    }
}
