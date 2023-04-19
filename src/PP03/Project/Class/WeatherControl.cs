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
        public WeatherControl(Indications[] arr)
        {
            ArrOfIndications = arr;
        }
        /// <summary>
        /// Сортировка по возрастанию сначала по температуре, при равной температуре сортирует по влажности
        /// </summary>
        public void SortByAscending()
        {
            Indications temp;
            for (int i = 0; i < ArrOfIndications.Length; i++)
            {
                for (int j = 0; j < ArrOfIndications.Length - 1 - i; j++)
                {
                    if (ArrOfIndications[j].Temperature > ArrOfIndications[j + 1].Temperature)
                    {
                        temp = ArrOfIndications[j + 1];
                        ArrOfIndications[j + 1] = ArrOfIndications[j];
                        ArrOfIndications[j] = temp;
                    }
                    else if (ArrOfIndications[j].Temperature == ArrOfIndications[j + 1].Temperature)
                    {
                        if (ArrOfIndications[j].Humidity > ArrOfIndications[j + 1].Humidity)
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
                Console.WriteLine($"{ArrOfIndications[i].Humidity}\t\t{ArrOfIndications[i].Pressure}\t\t{ArrOfIndications[i].Temperature}");
            }
        }
        public void SaveArrOnFile()
        {

        }
    }
}
