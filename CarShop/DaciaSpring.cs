namespace CarShop
{
    public class DaciaSpring : Build
    {
        public DaciaSpring() => AutonomousDriving = new NotDrive();

        public override string BuildCar() => " in Romania - ";
    }
}