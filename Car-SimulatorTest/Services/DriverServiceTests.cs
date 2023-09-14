using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DriverLibrary;
using Moq;
using ServiceLibrary.Services;

namespace Car_SimulatorTest.Services
{
    [TestClass]
    public class DriverServiceTests
    {
        private DriverService _sut;

        public DriverServiceTests()
        {
            _sut = new DriverService();
        }

        [TestMethod]
        public void GetApiResult_Is_Not_Null()
        {
            var result = _sut.GetApiResult();

            Assert.IsNotNull(result);

        }


        [TestMethod]
        public void GetApiResult_Gives_API_Result_First_Name()
        {

            var result = _sut.GetApiResult();

            var apiFirstName = result.Result.Name.First;

            Assert.IsNotNull(apiFirstName);
        }

        [TestMethod]
        public void GetApiResult_Gives_API_Result_Last_Name()
        {

            var result = _sut.GetApiResult();

            var apiLastName = result.Result.Name.Last;

            Assert.IsNotNull(apiLastName);

        }

        
        [TestMethod]
        public void GetApiResult_Gives_API_Result_Title()
        {
            var result = _sut.GetApiResult();

            var apiTitle = result.Result.Name.Title;

            Assert.IsNotNull(apiTitle);

        }

        [TestMethod]
        public void GetApiResult_Gives_API_Result_Age()
        {
            var result = _sut.GetApiResult();

            var apiAge = result.Result.Dob.Age;

            Assert.IsNotNull(apiAge);

        }

        [TestMethod]
        public void GetApiResult_Gives_API_Result_Gender()
        {
            var result = _sut.GetApiResult();

            var apiGender = result.Result.Gender;

            Assert.IsNotNull(apiGender);

        }

        [TestMethod]
        public void GetApiResult_Gives_API_Result_Email()
        {
            var result = _sut.GetApiResult();

            var apiEmail = result.Result.Email;

            Assert.IsNotNull(apiEmail);

        }



        [TestMethod]
        public void CreateDriver_Creates_Driver_With_API_Filled_Properties()
        {
            var result = _sut.GetApiResult();

            var driver = _sut.CreateDriver(result);

            Assert.IsNotNull(driver.FirstName);

        }


        [TestMethod]

        public void GetDriver_Gives_Complete_Driver()
        {
            var expected = 20;

            var driver = _sut.GetDriver();
            var result = driver.Energy;

            Assert.AreEqual(expected, result);

        }

        [TestMethod]

        public void Driver_Energy_Reduces()
        {
            var driver = new Driver
            {
                Age = "",
                Email = "",
                FirstName = "",
                LastName = "",
                Gender = "",
                Energy = 10
            };

            var expected = 9;

            var result = _sut.DriverGetsTired(driver);


            Assert.AreEqual(expected, result.Energy);

        }



    }
}
