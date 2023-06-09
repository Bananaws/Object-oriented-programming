﻿using MeasuringDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsEnumeration;
using DeviceController_namespace;

namespace MeasureDataDevice_namespace
{
    public abstract class MeasureDataDevice
    {
        public abstract decimal ImperialValue();
        public abstract decimal MetricValue();

        protected Units unitsToUse;
        protected int[]? dataCaptured;
        protected int mostRecentMeasure;
        protected DeviceController? controller;
        protected DeviceType measurementType;

        public int[] GetRawData()
        {
            return dataCaptured;
        }
        public void StartCollecting()
        {
            controller = DeviceController.StartDevice(measurementType);
            GetMeasurements();
        }
        public void StopCollecting()
        {
            if (controller != null)
            {
                controller.StopDevice();
                controller = null;
            }
        }
        private void GetMeasurements()
        {
            dataCaptured = new int[10];
            System.Threading.ThreadPool.QueueUserWorkItem((dummy) =>
            {
                int x = 0;
                Random timer = new Random();

                while (controller != null)
                {
                    System.Threading.Thread.Sleep(timer.Next(1000, 5000));
                    dataCaptured[x] = controller != null ?
                        controller.TakeMeasurement() : dataCaptured[x];
                    mostRecentMeasure = dataCaptured[x];
                    x++;
                    if (x == 10)
                    {
                        x = 0;
                    }
                }
            });
        }

    }
}
