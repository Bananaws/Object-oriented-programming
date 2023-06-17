using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeasureDataDevice_namespace;
using MeasuringDevice;
using UnitsEnumeration;

namespace MeasureLenghtDevice_namespace
{
    internal class MeasureLenghtDevice: MeasureDataDevice, IMeasuringDevice
    {
        public MeasureLenghtDevice(Units unitToUse)
        {
            measurementType = DeviceType.Length;
            unitsToUse = unitToUse;
        }
        public override decimal MetricValue()
        {
            if (unitsToUse == Units.Metric) return mostRecentMeasure;
            else return Convert.ToDecimal(mostRecentMeasure * 25.4);
        }
        public override decimal ImperialValue()
        {
            if (unitsToUse == Units.Imperial) return mostRecentMeasure;
            else return Convert.ToDecimal(mostRecentMeasure * 0.03937);
        }
    }
}
