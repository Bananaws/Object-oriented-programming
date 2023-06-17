using MeasuringDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasuaringDevice
{
    delegate void HeartBeatEventHandler(); // Делегат для события HeartBeat
    interface IEventEnabledMeasuringDevice : IMeasuringDevice
    {
        event EventHandler? NewMeasurementTaken;
        // Событие, которое должно срабатывать при каждом Heartbeat
        event HeartBeatEventHandler HeartBeat;

        // Интервал Heartbeat, доступный только для чтения. Устанавливается только в конструкторе.
        int HeartBeatInterval { get; }
    }
}
