using System;

namespace CarShop
{
    public sealed class ShopSingleton
    {
        private static ShopSingleton _shopSingleton;
        private int _carsSold;

        private ShopSingleton()
        {
            _carsSold = 0;
        }

        public static ShopSingleton GetInstance()
        {
            if (_shopSingleton == null)
            {
                _shopSingleton = new ShopSingleton();
            }

            return _shopSingleton;
        }
        public Tuple<int, Build> SellCar(string carType)
        {
            _carsSold++;
            return new(_carsSold, CarFactory.GetCar(carType));
        }
    }
}