using CarLibrary;
using DriverLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Services.Direction;

namespace ServiceLibrary.Services.Menu
{
    public enum ChoiceEnum
    {
        NotDefined,
        Forward,
        Left,
        Reverse,
        Right,
        Gas,
        Rest,
        Quit
    }

    public class StatusService : IStatusService
    {
        private readonly IForwardDirectionService _forwardDirectionService;
        private readonly IReverseDirectionService _reverseDirectionService;
        private readonly ICarService _carService;
        private readonly IDriverService _driverService;

        public StatusService(IForwardDirectionService forwardDirectionService,
            IReverseDirectionService reverseDirectionService,
            ICarService carService,
            IDriverService driverService)
        {
            _forwardDirectionService = forwardDirectionService;
            _reverseDirectionService = reverseDirectionService;
            _carService = carService;
            _driverService = driverService;
        }

        public bool GetStatus(Car car, Driver driver)
        {
            Console.WriteLine("\n----STATUS----\n");

            var status = _driverService.DriverStatus(driver);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(status);
            Console.ResetColor();

            Console.WriteLine($"Driving Direction: {car.Direction}");
            Console.WriteLine($"{driver.Title}. {driver.FirstName} Energy Level: {driver.Energy}/20");
            Console.WriteLine($"Gas Tank: {car.Gas}/30\n\n\n");

            _carService.CarAlert(car, driver);

            var inputChoice = "";

            if (car.IsEmpty)
            {
                Console.Write("[G] or [Q]: ");
                var quitOrGas = Console.ReadLine();
                if (quitOrGas.ToUpper() == "G" || quitOrGas.ToUpper() == "Q")
                {
                    inputChoice = quitOrGas;
                    car.IsEmpty = false;
                }


            }
            else
            {
                Console.Write("Enter choice: ");
                inputChoice = Console.ReadLine();
            }


            var menuChoice = InputChoice(inputChoice);


            if (!car.IsEmpty && menuChoice != ChoiceEnum.NotDefined)
            {
                car = _carService.CarMoves(car);
                if (driver.Energy != 0)
                {
                    driver = _driverService.DriverGetsTired(driver);
                }


            }


            switch (menuChoice)
            {
                case ChoiceEnum.Forward:
                    {
                        if (car.IsBacking)
                        {
                            _reverseDirectionService.DriveForward(car);
                        }

                        Console.WriteLine("Driving Forward!");
                        Console.ReadLine();
                        break;
                    }
                case ChoiceEnum.Left:
                    {
                        if (car.IsBacking)
                        {
                            _reverseDirectionService.TurnLeft(car);
                        }
                        else
                        {
                            _forwardDirectionService.TurnLeft(car);
                        }

                        Console.WriteLine("Turning Left!");
                        Console.ReadLine();
                        break;
                    }
                case ChoiceEnum.Reverse:
                    {
                        if (!car.IsBacking)
                        {
                            _forwardDirectionService.Reverse(car);
                        }

                        Console.WriteLine("Reverse Driving!");
                        Console.ReadLine();
                        break;
                    }
                case ChoiceEnum.Right:
                    {
                        if (car.IsBacking)
                        {
                            _reverseDirectionService.TurnRight(car);
                        }
                        else
                        {
                            _forwardDirectionService.TurnRight(car);

                        }

                        Console.WriteLine("Turning Right!");
                        Console.ReadLine();
                        break;
                    }
                case ChoiceEnum.Rest:
                    {
                        driver.Energy = 20;
                        Console.WriteLine("Going For A Rest!");
                        Console.ReadLine();
                        break;
                    }
                case ChoiceEnum.Gas:
                    {
                        car.Gas = 30;
                        Console.WriteLine("Putting Gas In Car!");
                        Console.ReadLine();
                        break;
                    }

                case ChoiceEnum.Quit:
                    {
                        return true;
                    }


                case ChoiceEnum.NotDefined:
                    {
                        Console.Write("Invalid choice!");
                        Console.ReadLine();

                        break;
                    }

            }

            return false;
        }



        public ChoiceEnum InputChoice(string inputChoice)
        {

            switch (inputChoice.ToUpper())
            {
                case "W":
                    {
                        return ChoiceEnum.Forward;
                    }
                case "A":
                    {
                        return ChoiceEnum.Left;
                    }
                case "S":
                    {
                        return ChoiceEnum.Reverse;
                    }
                case "D":
                    {
                        return ChoiceEnum.Right;
                    }
                case "R":
                    {
                        return ChoiceEnum.Rest;
                    }
                case "G":
                    {
                        return ChoiceEnum.Gas;
                    }

                case "Q":
                    {
                        return ChoiceEnum.Quit;
                    }


                default:
                    {
                        return ChoiceEnum.NotDefined;
                    }

            }


        }



    }
}
