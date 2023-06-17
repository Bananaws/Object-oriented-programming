using MeasuringDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsEnumeration;
using DeviceController_namespace;
using MeasuaringDevice;
using System.ComponentModel;

namespace MeasureDataDevice_namespace
{
    public abstract class MeasureDataDevice: IEventEnabledMeasuringDevice
    {
        event HeartBeatEventHandler IEventEnabledMeasuringDevice.HeartBeat
        {
            add
            {
                
            }

            remove
            {
                
            }
        }
        protected virtual void OnNewMeasurementTaken() => NewMeasurementTaken?.Invoke(this, EventArgs.Empty);
        private BackgroundWorker dataCollector;


        public abstract decimal ImperialValue();
        public abstract decimal MetricValue();

        protected Units unitsToUse;
        protected int[]? dataCaptured;
        protected DeviceController? controller;
        protected DeviceType measurementType;
        public int mostRecentMeasure;
        public int HeartBeatInterval => throw new NotImplementedException();

        public event EventHandler? NewMeasurementTaken;

        public int[] GetRawData()
        {
            return dataCaptured;
        }

        private void GetMeasurements()
        {

            dataCollector = new BackgroundWorker();
            dataCollector.WorkerReportsProgress = true;
            dataCollector.WorkerSupportsCancellation = true;

            dataCollector.DoWork += new DoWorkEventHandler(dataCollector_DoWork);
            dataCollector.ProgressChanged += new ProgressChangedEventHandler(dataCollector_ProgressChanged);

            dataCollector.RunWorkerAsync();
        }

        public bool disposed = false;
        private StreamWriter? loggingFileWriter;
        public void StopCollecting()
        {
            if (controller != null)
            {
                controller.StopDevice();
                controller = null;
            }
            loggingFileWriter?.Close();
            loggingFileWriter?.Dispose();
            dataCollector?.CancelAsync();
            Dispose();
        }
        private void Dispose()
        {
            disposed = true;
            dataCollector?.Dispose();
        }

        public void StartCollecting()
        {
            controller = DeviceController.StartDevice(measurementType);
            loggingFileWriter = new StreamWriter("log.txt");
            GetMeasurements();
        }
        private void dataCollector_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            OnNewMeasurementTaken();
        }

        private void dataCollector_DoWork(object? sender, DoWorkEventArgs e) // сбор и хранение данных измерений
        {
            dataCaptured = new int[10];
            int i = 0;

            while (dataCollector?.CancellationPending == false && disposed == false)
            {
                dataCaptured[i] = controller != null ?
                    controller.TakeMeasurement() : dataCaptured[i];
                mostRecentMeasure = dataCaptured[i];
                
                loggingFileWriter?.WriteLine($"Measurement - {mostRecentMeasure}");
                Thread.Sleep(1000);
                dataCollector.ReportProgress(0);
                i = (i + 1) % 10;
            }
        }




    }
}
