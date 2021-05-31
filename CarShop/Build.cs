namespace CarShop
{
    public abstract class Build
    {
        public abstract string BuildCar();

        protected IAutonomous AutonomousDriving;

        public string GetAutonomousDriving() => AutonomousDriving.DriveAutonomous();
        public void SetAutonomousDriving(IAutonomous newDrivingType) => AutonomousDriving = newDrivingType;
    }
}