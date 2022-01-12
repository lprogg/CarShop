namespace CarShop
{
    public class DaciaSpring : Build
    {
        public DaciaSpring() => AutonomousDrivingStrategy = new NonAutonomousDriving();

        public override string BuildCar() => " in Romania - ";
    }
}