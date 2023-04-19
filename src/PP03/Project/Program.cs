using Project.Class;
using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            Indications[] arr;
            // Создание экземпляров класса Indications
            Console.Write("Введите размер массива: ");
            try
            {
                k = Int32.Parse(Console.ReadLine());
                if(k <= 0)
                {
                    Indications i1 = new Indications(30, 77, 2);
                    Indications i2 = new Indications(30, 22, 5);
                    Indications i3 = new Indications(31, 77, 6);
                    Indications i4 = new Indications(31, 75, 1);
                    Indications i5 = new Indications(31, 78, 2);
                    arr = new Indications[] { i5, i3, i2, i4, i1 };
                }
                else
                {
                    int p, h, t;
                    arr = new Indications[k];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write("Давление:");
                        p = Int32.Parse(Console.ReadLine());
                        Console.Write("Влажность:");
                        h = Int32.Parse(Console.ReadLine());
                        Console.Write("Температура:");
                        t = Int32.Parse(Console.ReadLine());
                        arr[i] = new Indications(t, h, p);
                    }
                }

                // Создание экземплярa класса WeatherControl
                WeatherControl weatherControl = new WeatherControl(arr);
                // Вывод данных до сортировки
                Console.WriteLine("\n\nДо сортировки:\n\n");
                weatherControl.DisplayOfArr();
                // Сортировка
                weatherControl.SortByAscending();
                // Вывод данных после сортировки
                Console.WriteLine("\n\nПосле сортировки:\n\n");
                weatherControl.DisplayOfArr();
                // Сохранение в файл
                weatherControl.SaveArrOnFile();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
