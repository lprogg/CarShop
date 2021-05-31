using System;

namespace CarShop
{
    public class Print
    {
        public static void PrintMethod(int carsSold, string buildCar, string auto)
        {
            Console.Write(carsSold + buildCar + auto);
            Console.WriteLine();
        }
    }
}