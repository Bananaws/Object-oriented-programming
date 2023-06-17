using MeasureLenghtDevice_namespace;
using MeasureMassDevice_namespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsEnumeration;

namespace DeviceController_namespace
{
    public class DeviceController
    {
        public static DeviceController StartDevice(DeviceType measurementType)
        {
            DeviceController controller = new DeviceController();
            return controller;
        }
        public void StopDevice()
        {
            MessageBox.Show("Внимание! Устройство остановлено.");
        }
        public int TakeMeasurement()
        {
            int random_number = new Random().Next(0, 1000);
            return random_number;
        }
    }
}
