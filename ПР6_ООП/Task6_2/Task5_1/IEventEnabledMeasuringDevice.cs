using MeasuringDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasuaringDevice
{
    interface IEventEnabledMeasuringDevice : IMeasuringDevice
    {
        int HeartBeatInterval { get; } // Интервал Heartbeat, доступный только для чтения

        event EventHandler NewMeasurementTaken;
        // Событие, которое должно срабатывать при каждом Heartbeat

        delegate void HeartBeatEventHandler();
        // Делегат для события HeartBeat
    }
}
