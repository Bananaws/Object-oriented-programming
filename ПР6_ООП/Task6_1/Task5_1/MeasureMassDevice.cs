using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsEnumeration;
using MeasureDataDevice_namespace;
using MeasuringDevice;

namespace MeasureMassDevice_namespace
{
    internal class MeasureMassDevice: MeasureDataDevice, IMeasuringDevice
    {
        public MeasureMassDevice(Units unitToUse)
        {
            measurementType = DeviceType.Mass;
            unitsToUse = unitToUse;
        }
        public override decimal MetricValue()
        {
            if (unitsToUse == Units.Metric) return mostRecentMeasure;
            else return Convert.ToDecimal(mostRecentMeasure * 0.4536);
        }
        public override decimal ImperialValue()
        {
            if (unitsToUse == Units.Imperial) return mostRecentMeasure;
            else return Convert.ToDecimal(mostRecentMeasure * 2.2046);
        }
    }
}
