using MeasureDataDevice_namespace;
using MeasureLenghtDevice_namespace;
using MeasureMassDevice_namespace;
using UnitsEnumeration;
namespace Task5_1
{
    public partial class Form1 : Form
    {
        MeasureDataDevice current_device;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Кнопка "Выбрать"
        {
            string l_box1 = listBox1.Text;
            string l_box3 = listBox3.Text;
            Units select_unit = Units.Metric;
            switch (l_box1)
            {
                case "Metric":
                    select_unit = Units.Metric;
                    break;
                case "Imperial":
                    select_unit = Units.Imperial;
                    break;
            };
            current_device = l_box3 switch
            {
                "Length" => new MeasureLenghtDevice(select_unit),
                "Mass" => new MeasureMassDevice(select_unit)
            };
        }

        private void button2_Click(object sender, EventArgs e) // Кнопка "Начать сбор данных"
        {
            if (current_device != null)
            {
                current_device.StartCollecting();
            }
        }

        private void button3_Click(object sender, EventArgs e) // Кнопка "Получить данные"
        {
            if (current_device != null)
            {
                listBox2.Items.Clear();
                int[] data = current_device.GetRawData();
                if (data != null)
                {
                    foreach (int i in data)
                    {
                        listBox2.Items.Add(i);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) // Кнопка "Остановить сбор данных"
        {
            if (current_device != null)
            {
                current_device.StopCollecting();
                listBox2.Items.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e) // Кнопка "Выдать в Metric"
        {
            if (current_device != null)
            {
                textBox1.Text = current_device.MetricValue().ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e) // Кнопка "Выдать в Imperial"
        {
            if (current_device != null)
            {
                textBox1.Text = current_device.ImperialValue().ToString();
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}