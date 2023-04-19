using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Class
{
    class Indications
    {
        /// <summary>
        /// Температура
        /// </summary>
        public int Temperature;
        /// <summary>
        /// Влажность
        /// </summary>
        public int Humidity;
        /// <summary>
        /// Давление
        /// </summary>
        public int Pressure;
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="t">Температура</param>
        /// <param name="h">Влажность</param>
        /// <param name="p">Давление</param>
        Indications(int t, int h, int p)
        {
            Temperature = t;
            Humidity = h;
            Pressure = p;
        }
    }
}
