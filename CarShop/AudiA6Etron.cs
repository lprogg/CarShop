namespace CarShop
{
    public class AudiA6Etron : Build
    {
        public AudiA6Etron() => AutonomousDrivingStrategy = new AutonomousDriving();

        public override string BuildCar() => " in Germany - ";
    }
}