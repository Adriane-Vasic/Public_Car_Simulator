using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;
using ServiceLibrary.Services.Direction;

namespace Car_SimulatorTest.Services
{
    [TestClass]
    public class ReverseDirectionServiceTests
    {
        private ReverseDirectionService _sut;

        public ReverseDirectionServiceTests()
        {
            _sut = new ReverseDirectionService();
        }


        [TestMethod]
        public void Direction_North_Is_East_On_Left_Turn()
        {
            var car = new Car
            {
                Direction = DirectionEnum.North,
                Gas = 30, IsBacking = false, IsEmpty = false
            };

            var expected = DirectionEnum.East;

            var run = _sut.TurnLeft(car);

            var result = run.Direction;

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Direction_South_Is_West_On_Left_Turn()
        {
            var car = new Car
            {
                Direction = DirectionEnum.South,
                Gas = 30, IsBacking = false, IsEmpty = false
            };

            var expected = DirectionEnum.West;

            var run = _sut.TurnLeft(car);

            var result = run.Direction;

            Assert.AreEqual(expected, result);

        } 
        
        [TestMethod]
        public void Direction_West_Is_North_On_Left_Turn()
        {
            var car = new Car
            {
                Direction = DirectionEnum.West,
                Gas = 30, IsBacking = false, IsEmpty = false
            };

            var expected = DirectionEnum.North;

            var run = _sut.TurnLeft(car);

            var result = run.Direction;

            Assert.AreEqual(expected, result);

        } 
        
        [TestMethod]
        public void Direction_East_Is_South_On_Left_Turn()
        {
            var car = new Car
            {
                Direction = DirectionEnum.East,
                Gas = 30, IsBacking = false, IsEmpty = false
            };

            var expected = DirectionEnum.South;

            var run = _sut.TurnLeft(car);

            var result = run.Direction;

            Assert.AreEqual(expected, result);

        } 


        [TestMethod]
        public void Direction_North_Is_South_On_Forward()
        {
            var car = new Car
            {
                Direction = DirectionEnum.North,
                Gas = 30, IsBacking = false, IsEmpty = false
            };

            var expected = DirectionEnum.South;


            var run = _sut.DriveForward(car);
            var result = run.Direction;


            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Direction_South_Is_North_On_Forward()
        {
            var car = new Car
            {
                Direction = DirectionEnum.South,
                Gas = 30, IsBacking = false, IsEmpty = false
            };

            var expected = DirectionEnum.North;


            var run = _sut.DriveForward(car);
            var result = run.Direction;


            Assert.AreEqual(expected, result);

        }


        [TestMethod]
        public void Direction_West_Is_East_On_Forward()
        {
            var car = new Car
            {
                Direction = DirectionEnum.West,
                Gas = 30, IsBacking = false, IsEmpty = false
            };

            var expected = DirectionEnum.East;


            var run = _sut.DriveForward(car);
            var result = run.Direction;


            Assert.AreEqual(expected, result);

        }    [TestMethod]
        public void Direction_East_Is_West_On_Forward()
        {
            var car = new Car
            {
                Direction = DirectionEnum.East,
                Gas = 30, IsBacking = false, IsEmpty = false
            };

            var expected = DirectionEnum.West;


            var run = _sut.DriveForward(car);
            var result = run.Direction;


            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Direction_North_Is_West_On_Right_Turn()
        {
            var car = new Car
            {
                Direction = DirectionEnum.North,
                Gas = 30, IsBacking = false, IsEmpty = false
            };

            var expected = DirectionEnum.West;

            var run = _sut.TurnRight(car);

            var result = run.Direction;

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Direction_South_Is_East_On_Right_Turn()
        {
            var car = new Car
            {
                Direction = DirectionEnum.South,
                Gas = 30, IsBacking = false, IsEmpty = false
            };

            var expected = DirectionEnum.East;

            var run = _sut.TurnRight(car);

            var result = run.Direction;

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Direction_West_Is_South_On_Right_Turn()
        {
            var car = new Car
            {
                Direction = DirectionEnum.West,
                Gas = 30, IsBacking = false, IsEmpty = false
            };

            var expected = DirectionEnum.South;

            var run = _sut.TurnRight(car);

            var result = run.Direction;

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Direction_East_Is_North_On_Right_Turn()
        {
            var car = new Car
            {
                Direction = DirectionEnum.East,
                Gas = 30, IsBacking = false, IsEmpty = false
            };

            var expected = DirectionEnum.North;

            var run = _sut.TurnRight(car);

            var result = run.Direction;

            Assert.AreEqual(expected, result);

        }
    }
}
