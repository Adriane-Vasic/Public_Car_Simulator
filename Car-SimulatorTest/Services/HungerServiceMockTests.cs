using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using ServiceLibrary.Services;
using ServiceLibrary.Services.Menu;

namespace Car_SimulatorTest.Services
{

    [TestClass]
    public class HungerServiceMockTests
    {
        private IHungerService _hungerService;

        [TestInitialize]
        public void Setup()
        {
            var mockHungerService = new Mock<IHungerService>();
            _hungerService = mockHungerService.Object;
        }

        [TestMethod]
        public void HungerEnum_Return_Full_If_HungerLever_Is_Zero()
        {
            Mock.Get(_hungerService)
                .Setup(dr => dr.Hunger(It.Is<int>(x => x == 0)))
                .Returns(HungerEnum.Full);

            var expected = HungerEnum.Full;

            var result = _hungerService.Hunger(0);

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void HungerEnum_Return_Hungry_If_HungerLever_Is_Between_Five_And_Ten()
        {
            var random = new Random();
            var hungerLevel = random.Next(5, 11);

            Mock.Get(_hungerService)
                .Setup(dr => dr.Hunger(It.Is<int>(x => x < 11 && x > 4)))
                .Returns(HungerEnum.Hungry);

            var expected = HungerEnum.Hungry;

            var result = _hungerService.Hunger(hungerLevel);

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void HungerEnum_Return_Starving_If_HungerLever_Is_Between_Eleven_And_Fifteen()
        {
            var random = new Random();
            var hungerLevel = random.Next(11, 16);

            Mock.Get(_hungerService)
                .Setup(dr => dr.Hunger(It.Is<int>(x => x < 16 && x > 10)))
                .Returns(HungerEnum.Starving);

            var expected = HungerEnum.Starving;

            var result = _hungerService.Hunger(hungerLevel);

            Assert.AreEqual(expected, result);
        }



        [TestMethod]
        public void HungerEnum_Return_Dead_If_HungerLever_Is_Over_Fifteen()
        {
            var hungerLevel = 16;

            Mock.Get(_hungerService)
                .Setup(dr => dr.Hunger(It.Is<int>(x => x >= 16)))
                .Returns(HungerEnum.Dead);

            var expected = HungerEnum.Dead;

            var result = _hungerService.Hunger(hungerLevel);

            Assert.AreEqual(expected, result);

        }


        [TestMethod]
        public void HungerEnum_Dead_Quit_Simulation()
        {
            var hunger = HungerEnum.Dead;

            Mock.Get(_hungerService)
                .Setup(dr => dr.Starved(It.Is<HungerEnum>(x => x == HungerEnum.Dead)))
                .Returns("Q");

            var expected = "Q";

            var result = _hungerService.Starved(hunger);

            Assert.AreEqual(expected, result);

        }


        [TestMethod]
        public void GetHungerLevel_Action_Adds_Two_To_Hunger()
        {
            var hunger = 5;

            Mock.Get(_hungerService)
                .Setup(dr => dr.GetHungerLevel(It.Is<ChoiceEnum>(x => x == ChoiceEnum.Forward)))
                .Returns(2);

            var expected = 7;


            hunger += _hungerService.GetHungerLevel(ChoiceEnum.Forward);

            Assert.AreEqual(expected, hunger);

        }

        [TestMethod]
        public void GetHungerLevel_Eat_Resets_Hunger_To_Zero()
        {
            var mockEat = ChoiceEnum.NotDefined;
            var hunger = 5;

            Mock.Get(_hungerService)
                .Setup(dr => dr.GetHungerLevel(It.Is<ChoiceEnum>(x => x == mockEat)))
                .Returns(0);

            var expected = 0;

          
            hunger = _hungerService.GetHungerLevel(mockEat);

            Assert.AreEqual(expected, hunger);

        }

    }

}


