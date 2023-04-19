using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Class
{
    class WeatherControl
    {
        /// <summary>
        /// Массив экземпляров класса типа Indications
        /// </summary>
        Indications[] ArrOfIndications;
        /// <summary>
        /// Конструктор класса. Нужен для заполнения массива
        /// </summary>
        /// <param name="arr">массив</param>
        WeatherControl(Indications[] arr)
        {
            ArrOfIndications = arr;
        }
        /// <summary>
        /// Сортировка по возрастанию
        /// </summary>
        void SortByAscending()
        {

        }
    }
}
