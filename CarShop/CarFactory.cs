using System;

namespace CarShop
{
    public static class CarFactory
    {
        public static Build GetCar(string carType) => carType switch
        {
            "Dacia" => new DaciaSpring(),
            "Tesla" => new TeslaModelS(),
            "Audi" => new AudiA6Etron(),
            _ => throw new InvalidOperationException("Can't build a car without a valid type.")
        };
    }
}