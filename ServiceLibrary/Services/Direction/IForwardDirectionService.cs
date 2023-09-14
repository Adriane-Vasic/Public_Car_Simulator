using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;

namespace ServiceLibrary.Services.Direction
{
    public interface IForwardDirectionService
    {
        Car TurnLeft(Car car);
        Car TurnRight(Car car);
        Car Reverse(Car car);
    }
}
