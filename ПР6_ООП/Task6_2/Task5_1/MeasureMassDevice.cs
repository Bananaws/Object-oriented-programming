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
        public MeasureMassDevice(Units unitToUse, int heartBeatInterval)
        {
            measurementType = DeviceType.Mass;
            this.unitsToUse = unitToUse;
            this.dataCaptured = new int[0];
            this.heartBeatInterval = heartBeatInterval;
        }

        public MeasureMassDevice(Units deviceUnits) : this(deviceUnits, 1000) { }
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
