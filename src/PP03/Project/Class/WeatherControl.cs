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
        public void SortByAscending()
        {
            Indications temp;
            for (int i = 0; i < ArrOfIndications.Length; i++)
            {
                for (int j = 0; j < ArrOfIndications.Length - 1 - i; j++)
                {
                    if (ArrOfIndications[j].Humidity > ArrOfIndications[j + 1].Humidity)
                    {
                        temp = ArrOfIndications[j + 1];
                        ArrOfIndications[j + 1] = ArrOfIndications[j];
                        ArrOfIndications[j] = temp;
                    }
                    else if (ArrOfIndications[j].Humidity == ArrOfIndications[j + 1].Humidity)
                    {
                        if (ArrOfIndications[j].Temperature > ArrOfIndications[j + 1].Temperature)
                        {
                            temp = ArrOfIndications[j + 1];
                            ArrOfIndications[j + 1] = ArrOfIndications[j];
                            ArrOfIndications[j] = temp;
                        }
                    }
                }
            }
            Console.WriteLine("Влажность\tДавление\tТемпература");
            for (int i = 0; i < ArrOfIndications.Length; i++)
            {
                Console.Write($"{ArrOfIndications[i].Humidity}\t{ArrOfIndications[i].Pressure}\t{ArrOfIndications[i].Temperature}");
            }
        }
        public void SaveArrOnFile()
        {

        }
    }
}
