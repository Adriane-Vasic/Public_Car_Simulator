using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;
using DriverLibrary;
using Microsoft.Extensions.DependencyInjection;
using ServiceLibrary.Services;
using ServiceLibrary.Services.Menu;

namespace Car_Simulator
{
    public class Application
    {

        private readonly ICarService _carService;
        private readonly IDriverService _driverService;
        private readonly ISimulatorService _simulatorService;

        public Application(ICarService carService, IDriverService driverService, ISimulatorService simulatorService)
        {
            _carService = carService;
            _driverService = driverService;
            _simulatorService = simulatorService;
        }

        public void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var car = _carService.GetCar();
            var driver = _driverService.GetDriver();
            _simulatorService.Menu(car, driver);
        }


    }
}
