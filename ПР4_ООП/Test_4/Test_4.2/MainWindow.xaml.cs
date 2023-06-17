using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Test_4._2
{
        /// <summary>
        /// Enumeration of girder material types
        /// </summary>
        public enum Material
        {
            StainlessSteel,
            Aluminium,
            ReinforcedConcrete,
            Composite,
            Titanium
        }
        /// <summary>
        /// Enumeration of girder cross-sections
        /// </summary>
        public enum CrossSection
        {
            IBeam,
            Box,
            ZShaped,
            CShaped
        }
        /// <summary>
        /// Enumeration of test results
        /// </summary>
        public enum TestResult
        {
            Pass,
            Fail
        }
        // Structures Exercise 2
        /// <summary>
        /// Structure containing test results
        /// </summary>
        public struct TestCaseResult
        {
            /// <summary>
            /// Test result (enumeration type)
            /// </summary>
            public TestResult Result;
            /// <summary>
            /// Description of reason for failure
            /// </summary>
            public string ReasonForFailure;
            public TestCaseResult(TestResult Result, string ReasonForFailure)
            {
                this.Result = Result;
                this.ReasonForFailure = ReasonForFailure;
            }
        }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public void loop_array(Array arr, ListBox listbox) // метод помещает в листбокс объекты enum в виде массива
        {
            foreach (object obj in arr)
            {
                listbox.Items.Add(obj);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            // создаём массивы, вытаскивая информацию из enum'ов
            Array arr1 = typeof(Material).GetEnumValues(); 
            Array arr2 = typeof(CrossSection).GetEnumValues();
            Array arr3 = typeof(TestResult).GetEnumValues();
            //Помещаем в листбокс
            loop_array(arr1, materials);
            loop_array(arr2, crosssections);
            loop_array(arr3, testresults);
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e) // Метод вписывает выбранные данные в stringBuilder и вывод через label
        {
            StringBuilder selectionStringBuilder = new(); // создаём объект stringbuilder

            if (materials.SelectedItem != null) // если содержимое в листбоксах не null
            {
                Material selectedMaterial = (Material)materials.SelectedItem;
                switch (selectedMaterial)
                {
                    case Material.StainlessSteel:
                        selectionStringBuilder.Append("Stainless Steel");
                        break;
                    case Material.Aluminium:
                        selectionStringBuilder.Append("Aluminium");
                        break;
                    case Material.ReinforcedConcrete:
                        selectionStringBuilder.Append("Reinforced Concrete");
                        break;
                    case Material.Composite:
                        selectionStringBuilder.Append("Composite");
                        break;
                    case Material.Titanium:
                        selectionStringBuilder.Append("Titanium");
                        break;
                }
                selectionStringBuilder.Append("  "); // добавляем в строчку
            }

            if (crosssections.SelectedItem != null) // если содержимое в листбоксах не null
            {
                CrossSection selectedCrossSection = (CrossSection)crosssections.SelectedItem;
                switch (selectedCrossSection)
                {
                    case CrossSection.IBeam:
                        selectionStringBuilder.Append("I-Beam");
                        break;
                    case CrossSection.Box:
                        selectionStringBuilder.Append("Box");
                        break;
                    case CrossSection.ZShaped:
                        selectionStringBuilder.Append("Z-Shaped");
                        break;
                    case CrossSection.CShaped:
                        selectionStringBuilder.Append("C-Shaped");
                        break;
                }
                selectionStringBuilder.Append("  "); // добавляем в строчку
            }

            if (testresults.SelectedItem != null) // если содержимое в листбоксах не null
            {
                TestResult selectedTestResult = (TestResult)testresults.SelectedItem;
                switch (selectedTestResult)
                {
                    case TestResult.Pass:
                        selectionStringBuilder.Append("Pass");
                        break;
                    case TestResult.Fail:
                        selectionStringBuilder.Append("Fail");
                        break;
                }
                selectionStringBuilder.Append("  "); // добавляем в строчку
            }

            label1.Content = selectionStringBuilder.ToString(); // вывод результата в label
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            StringBuilder selectionStringBuilder = new();
            
            int material_durability = 0;
            switch (rnd.Next(0, 4))
            {
                case 0:
                    selectionStringBuilder.Append("Stainless Steel");
                    material_durability = 8;
                    break;
                case 1:
                    selectionStringBuilder.Append("Aluminium");
                    material_durability = 3;
                    break;
                case 2:
                    selectionStringBuilder.Append("Reinforced Concrete");
                    material_durability = 5;
                    break;
                case 3:
                    selectionStringBuilder.Append("Composite");
                    material_durability = 7;
                    break;
                case 4:
                    selectionStringBuilder.Append("Titanium");
                    material_durability = 10;
                    break;
            }
            selectionStringBuilder.Append("  "); // добавляем в строчку
            int material_damage = 0;
            switch (rnd.Next(0, 3))
            {
                case 0:
                    selectionStringBuilder.Append("I-Beam");
                    material_damage = 2;
                    break;
                case 1:
                    selectionStringBuilder.Append("Box");
                    material_damage = 5;
                    break;
                case 2:
                    selectionStringBuilder.Append("Z-Shaped");
                    material_damage = 6;
                    break;
                case 3:
                    selectionStringBuilder.Append("C-Shaped");
                    material_damage = 8;
                    break;
            }
            selectionStringBuilder.Append("  "); // добавляем в строчку

            int res = material_durability - material_damage;

            TestCaseResult test = new TestCaseResult();
            if (res > 0)
            { 
                selectionStringBuilder.Append("Pass");
                test.Result = TestResult.Pass;
                test.ReasonForFailure = selectionStringBuilder.ToString() + $"{res} durability";
                TextBlock1.Text += test.Result.ToString() + "\n";
            }
            else
            {
                selectionStringBuilder.Append("Fail");
                test.Result = TestResult.Fail;
                test.ReasonForFailure = selectionStringBuilder.ToString() + $"   {res} durability";
                TextBlock1.Text += test.Result.ToString() + "    " + test.ReasonForFailure + "\n";
            }
        }
    }
}
