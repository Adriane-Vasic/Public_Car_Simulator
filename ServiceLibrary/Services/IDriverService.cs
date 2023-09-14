using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DriverLibrary;

namespace ServiceLibrary.Services
{
    public interface IDriverService
    {
        string DriverStatus(Driver driver);
        Driver GetDriver();
        Driver DriverGetsTired(Driver driver);
    }
}
