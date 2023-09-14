using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;
using DriverLibrary;

namespace ServiceLibrary.Services
{
    public class CarService : ICarService
    {
        public void CarAlert(Car car, Driver driver)
        {
           
            if (car.IsBacking)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("YOU ARE BACKING THE CAR");
                Console.ResetColor();

            }

         
            if (car.Gas == 0)
            {
                car.IsEmpty = true;
                Console.WriteLine("------------ CAR HAS STOPPED! IT IS OUT OF GAS! ------------");

            }

        }

        public Car CarMoves(Car car)
        {
            car.Gas -= 2;
            
            return car;
        }

        public Car GetCar()
        {
            var car = new Car
            {
                Gas = 30,
                Direction = DirectionEnum.North,
                IsEmpty = false,
                IsBacking = false
            };
            return car;
        }
    }
}
