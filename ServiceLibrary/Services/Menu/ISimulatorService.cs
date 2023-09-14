using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;
using DriverLibrary;

namespace ServiceLibrary.Services.Menu
{
    public interface ISimulatorService
    {
        void Menu(Car car, Driver driver);

    }
}
