using System;
using System.Linq;

namespace CarShop
{
    class Program
    {
        private static int _carsSold;
        private static Build _build;

        static void Main(string[] args)
        {
            var car = CarShop.GetInstance();
            const int numberOfClients = 2;

            Enumerable.Range(0, numberOfClients).ToList().ForEach(_ =>
                {
                    CarList.ListOfCars.ForEach(
                        item =>
                        {
                            (_carsSold, _build) = car.SellCar(item);
                            Print.PrintMethod(_carsSold, _build.GetType().Name, _build.BuildCar(), _build.GetAutonomousDriving());
                        });
                    Console.WriteLine();
                }
            );

            (_carsSold, _build) = car.SellCar("Dacia");
            _build.SetAutonomousDriving(new Drive());
            Print.PrintMethod(_carsSold, _build.GetType().Name, _build.BuildCar(), _build.GetAutonomousDriving());
        }
    }
}