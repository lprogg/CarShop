namespace CarShop
{
    public class AudiA6Etron : Build
    {
        public AudiA6Etron() => AutonomousDriving = new Drive();

        public override string BuildCar() => " in Germany - ";
    }
}