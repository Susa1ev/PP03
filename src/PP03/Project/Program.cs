using Project.Class;
using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Indications i1 = new Indications(30, 77, 2);
            Indications i2 = new Indications(30, 22, 5);
            Indications i3 = new Indications(31, 77, 6);
            Indications i4 = new Indications(31, 75, 1);
            Indications i5 = new Indications(31, 78, 2);
            //Indications i6 = new Indications(31, 77, 2); 
            //Indications i7 = new Indications(30, 77, 2);
            //Indications i8 = new Indications(30, 22, 2);
            //Indications i9 = new Indications(31, 77, 2);
            Indications[] arr = new Indications[] {i5,i3,i2,i4,i1};
            WeatherControl weatherControl = new WeatherControl(arr);
            Console.WriteLine("\n\nДо сортировки:\n\n");
            weatherControl.DisplayOfArr();
            weatherControl.SortByAscending();
            Console.WriteLine("\n\nПосле сортировки:\n\n");
            weatherControl.DisplayOfArr();
            weatherControl.SaveArrOnFile();
        }
    }
}
