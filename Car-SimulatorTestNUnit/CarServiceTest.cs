using CarLibrary;
using ServiceLibrary.Services;

namespace Car_SimulatorTestNUnit
{
    public class CarServiceTest
    {
        private CarService _sut;
        private DriverService _driverService;

        [SetUp]
        public void Setup()
        {
            _driverService = new DriverService();
            _sut = new CarService();
        }

        [Test]
        public void GetCar_Gives_Car_with_filled_properties()
        {
            var expected = new Car
            {
                Direction = DirectionEnum.North,
                Gas = 30, IsBacking = false, IsEmpty = false
            };

            var result = _sut.GetCar();

            Assert.That(result.Gas, Is.EqualTo(expected.Gas));
        }

        [Test]
        public void Car_Action_Reduces_Gas()
        {
            var car =  _sut.GetCar();

            var expected = 28;

            var result = _sut.CarMoves(car);

            Assert.That(result.Gas, Is.EqualTo(expected));

        }
    }
}