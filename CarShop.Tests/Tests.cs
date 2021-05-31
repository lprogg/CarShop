using Xunit;
using FluentAssertions;

namespace CarShop.Tests
{
    public class Tests
    {
        [Fact]
        public void GetCarType_WhenTheInputIsASpecificString()
        {
            const string str = "Dacia";
            var type = CarFactory.GetCar(str);
            Assert.IsType<string>(type.BuildCar());
        }

        [Fact]
        public void GetDaciaAutonomousSupport_WhenTheFactoryMethodIsCalled()
        {
            const string str = "Dacia";
            var type = CarFactory.GetCar(str);

            type.GetAutonomousDriving().Should().Be("Won't drive autonomous.");
        }

        [Fact]
        public void GetTeslaAutonomousSupport_WhenTheFactoryMethodIsCalled()
        {
            const string str = "Tesla";
            var type = CarFactory.GetCar(str);

            type.GetAutonomousDriving().Should().Be("Will drive autonomous.");
        }

        [Fact]
        public void GetAudiAutonomousSupport_WhenTheFactoryMethodIsCalled()
        {
            const string str = "Audi";
            var type = CarFactory.GetCar(str);

            type.GetAutonomousDriving().Should().Be("Will drive autonomous.");
        }

        [Fact]
        public void GetAutonomousSupportAfterSet_WhenTheFactoryMethodIsCalled()
        {
            const string str = "Dacia";
            var type = CarFactory.GetCar(str);

            type.SetAutonomousDriving(new Drive());
            type.GetAutonomousDriving().Should().Be("Will drive autonomous.");
        }
    }
}
