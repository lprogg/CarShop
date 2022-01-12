using System;

namespace CarShop
{
    public class Print
    {
        public static void PrintMethod(int carsSold, string type, string buildCar, string getAutonomousDriving)
        {
            Console.Write(carsSold + " Building " + type + buildCar + getAutonomousDriving);
            Console.WriteLine();
        }
    }
}