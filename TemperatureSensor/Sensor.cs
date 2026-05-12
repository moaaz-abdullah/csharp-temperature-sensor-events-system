using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureSensor
{
    internal class Sensor
    {
        public event EventHandler<TemperatureArgs>? TemperatureChanged;

        private int _currentTemperature;

        /// <summary>
        /// Receive a new temperature and replace the old one
        /// </summary>
        /// <param name="newTemperature"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void ChangeTemperature(int newTemperature)
        {
            if (newTemperature < -50 || newTemperature > 100)
                throw new ArgumentOutOfRangeException(nameof(newTemperature));

            _currentTemperature = newTemperature;

            OnTemperatureChanged(newTemperature);
        }

        protected virtual void OnTemperatureChanged(int temperature)
        {
            TemperatureChanged?.Invoke(this, new TemperatureArgs(temperature));
        }
    }
}
