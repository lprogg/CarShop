namespace CarShop
{
    public abstract class Build
    {
        public abstract string BuildCar();

        protected IAutonomousStrategy AutonomousDrivingStrategy;

        public string GetAutonomousDriving() => AutonomousDrivingStrategy.AutonomousDrivingAbility();
        public void SetAutonomousDriving(IAutonomousStrategy newDrivingType) => AutonomousDrivingStrategy = newDrivingType;
    }
}