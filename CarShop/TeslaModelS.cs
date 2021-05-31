namespace CarShop
{
    public class TeslaModelS : Build
    {
        public TeslaModelS() => AutonomousDriving = new Drive();

        public override string BuildCar() => " Building a Tesla Model S - ";
    }
}