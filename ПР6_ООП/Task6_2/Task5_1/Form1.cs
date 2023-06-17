using MeasureDataDevice_namespace;
using MeasureLenghtDevice_namespace;
using MeasureMassDevice_namespace;
using UnitsEnumeration;
using MeasuringDevice;
namespace Task5_1
{
    public partial class Form1 : Form
    {
        MeasureDataDevice current_device;
        EventHandler newMeasurementTaken;
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
            newMeasurementTaken = new EventHandler(device_NewMeasurementTaken);
            if (current_device == null)
            {
                MessageBox.Show("Устройство ещё не создано");
                return;
            }
            current_device.NewMeasurementTaken += newMeasurementTaken;
            current_device.HeartBeat += (o, args) =>
            {
                label4.Text = "HeartBeat Timestamp: " + args?.TimeStamp.ToString();
            };
            current_device.StartCollecting();
        }

        private void device_NewMeasurementTaken(object? sender, EventArgs e)
        {
            if (current_device != null)
            {
                textBox1.Text = current_device.MetricValue().ToString();
                textBox2.Text = current_device.ImperialValue().ToString();
                textBox3.Text = current_device.mostRecentMeasure.ToString();
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
                current_device.NewMeasurementTaken -= newMeasurementTaken;
            }
        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}