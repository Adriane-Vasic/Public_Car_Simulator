using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;
using DriverLibrary;
using ServiceLibrary.Services;

namespace Car_SimulatorTest.Services
{
    [TestClass]
    public class CarServiceTests
    {
        private CarService _sut;
        private DriverService _driverService;

        public CarServiceTests()
        {
            _driverService = new DriverService();
            _sut = new CarService();
        }

        [TestMethod]
        public void GetCar_Gives_Car_with_filled_properties()
        {
            var expected = new Car
            {
                Direction = DirectionEnum.North,
                Gas = 30, IsBacking = false, IsEmpty = false
            };

            var result = _sut.GetCar();

            Assert.AreEqual(expected.Gas, result.Gas);
        }

        [TestMethod]
        public void Car_Action_Reduces_Gas()
        {
            var car =  _sut.GetCar();

            var expected = 28;

            var result = _sut.CarMoves(car);

            Assert.AreEqual(expected, result.Gas);

        }

       

    }
}
