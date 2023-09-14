using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;

namespace ServiceLibrary.Services.Direction
{
    public interface IReverseDirectionService
    {
        Car TurnLeft(Car car);
        Car TurnRight(Car car);
        Car DriveForward(Car car);

    }
}
