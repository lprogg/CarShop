using System;

namespace CarShop
{
    public sealed class CarShop
    {
        private static CarShop _carShop;
        private int _carsSold;

        private CarShop()
        {
            _carsSold = 0;
        }

        public static CarShop GetInstance()
        {
            if (_carShop == null)
            {
                _carShop = new CarShop();
            }

            return _carShop;
        }
        public Tuple<int, Build> SellCar(string carType)
        {
            _carsSold++;
            return new(_carsSold, CarFactory.GetCar(carType));
        }
    }
}