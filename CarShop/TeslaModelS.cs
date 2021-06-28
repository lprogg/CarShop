namespace CarShop
{
    public class TeslaModelS : Build
    {
        public TeslaModelS() => AutonomousDrivingStrategy = new AutonomousDriving();

        public override string BuildCar() => " in USA - ";
    }
}