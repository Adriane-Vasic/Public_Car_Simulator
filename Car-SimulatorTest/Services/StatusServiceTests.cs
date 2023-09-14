using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;
using DriverLibrary;
using ServiceLibrary.Services;
using ServiceLibrary.Services.Direction;
using ServiceLibrary.Services.Menu;

namespace Car_SimulatorTest.Services
{
    [TestClass]
    public class StatusServiceTests
    {
        private readonly ForwardDirectionService _forwardDirectionService;
        private readonly ReverseDirectionService _reverseDirectionService;
        private readonly CarService _carService;
        private readonly DriverService _driverService;
        private readonly StatusService _sut;

        public StatusServiceTests()
        {
            _forwardDirectionService = new ForwardDirectionService();
            _reverseDirectionService = new ReverseDirectionService();
            _carService = new CarService();
            _driverService = new DriverService();

            _sut = new StatusService(_forwardDirectionService, _reverseDirectionService, _carService, _driverService);
        }

        [TestMethod]
        public void InputChoice_W_Return_Forward_ChoiceEnum()
        {
            var input = "W";

            var expected = ChoiceEnum.Forward;

            var result = _sut.InputChoice(input);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void InputChoice_S_Return_Reverse_ChoiceEnum()
        {
            var input = "S";

            var expected = ChoiceEnum.Reverse;

            var result = _sut.InputChoice(input);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void InputChoice_A_Return_Left_ChoiceEnum()
        {
            var input = "A";

            var expected = ChoiceEnum.Left;

            var result = _sut.InputChoice(input);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void InputChoice_D_Return_Right_ChoiceEnum()
        {
            var input = "D";

            var expected = ChoiceEnum.Right;

            var result = _sut.InputChoice(input);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void InputChoice_R_Return_Rest_ChoiceEnum()
        {
            var input = "R";

            var expected = ChoiceEnum.Rest;

            var result = _sut.InputChoice(input);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void InputChoice_G_Return_Gas_ChoiceEnum()
        {
            var input = "G";

            var expected = ChoiceEnum.Gas;

            var result = _sut.InputChoice(input);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void InputChoice_Q_Return_Quit_ChoiceEnum()
        {
            var input = "Q";

            var expected = ChoiceEnum.Quit;

            var result = _sut.InputChoice(input);

            Assert.AreEqual(expected, result);

        }
    }
}
