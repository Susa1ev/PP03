using System;
using System.IO;
using System.Reflection;

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
        }
        /// <summary>
        /// Сохранение текстового файла
        /// </summary>
        public void SaveArrOnFile()
        {
            var location = Assembly.GetExecutingAssembly().Location;
            var path = Path.GetDirectoryName(location);
            try
            {
                StreamWriter sw = new StreamWriter($"{path}\\Log.txt");
                sw.WriteLine("Влажность\tДавление\tТемпература");
                for (int i = 0; i < ArrOfIndications.Length; i++)
                {
                    sw.WriteLine($"{ArrOfIndications[i].Humidity}\t\t{ArrOfIndications[i].Pressure}\t\t{ArrOfIndications[i].Temperature}");
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine($"Запись в файл прошла успешно! \nПуть к файлу:{path}\\Log.txt");
            }
        }
        /// <summary>
        /// Вывод данных в консоль
        /// </summary>
        public void DisplayOfArr() 
        {
            Console.WriteLine("Влажность\tДавление\tТемпература");
            for (int i = 0; i < ArrOfIndications.Length; i++)
            {
                Console.WriteLine($"{ArrOfIndications[i].Humidity}\t\t{ArrOfIndications[i].Pressure}\t\t{ArrOfIndications[i].Temperature}");
            }
        }
    }
}
