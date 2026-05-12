using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureSensor
{
    internal class Alarm
    {
        private int AlarmValue { get; set; }

        private int _defaultAlarmValue = 30;

        public Alarm()
        {
            AlarmValue = _defaultAlarmValue;
        }

        public void SetAlarmValue(int newAlarmValue)
        {
            AlarmValue = newAlarmValue;
        }

        public void CheckTemperature(object? obj, TemperatureArgs args)
        {
            if (args.Temperature > AlarmValue)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Temperature is > than the threshold {AlarmValue}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}