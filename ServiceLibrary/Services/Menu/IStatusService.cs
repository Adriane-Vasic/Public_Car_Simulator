using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;
using DriverLibrary;

namespace ServiceLibrary.Services.Menu
{
    public interface IStatusService
    {
        bool GetStatus(Car car, Driver driver);

        ChoiceEnum InputChoice(string inputChoice);

        
    }
}
