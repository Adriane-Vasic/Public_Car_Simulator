using CarLibrary;
using DriverLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Services.Direction;
using System.Runtime.ConstrainedExecution;

namespace ServiceLibrary.Services.Menu
{
    public class SimulatorService : ISimulatorService
    {
       
        private readonly IStatusService _statusService;

        public SimulatorService(IStatusService statusService)
        {
            
            _statusService = statusService;
        }
        public void Menu(Car car, Driver driver)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("---WestHill Car Simulator---\n\t\t\t\t\t\t\t***************************************************************");
                Console.WriteLine($"[W] Drive Forward\t\t\t\t\t* DRIVER: {driver.Title}. {driver.FirstName} {driver.LastName}.");
                Console.WriteLine($"[A] Turn Left\t\t\t\t\t\t* {driver.Gender}, {driver.Age}, {driver.Email}");
                Console.WriteLine("[S] Reverse Drive\t\t\t\t\t***************************************************************");
                Console.WriteLine("[D] Turn Right\n");

                Console.WriteLine("[R] Rest Up");
                Console.WriteLine("[G] Gas Up Car");
                Console.WriteLine("[Q] Quit Simulation\n");

                var quit = _statusService.GetStatus(car, driver);

                if (quit)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\nGood Bye!");
                    break;
                }



            }

        }



    }
}
