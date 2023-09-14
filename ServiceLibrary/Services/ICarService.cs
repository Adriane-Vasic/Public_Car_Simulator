using CarLibrary;
using DriverLibrary;

namespace ServiceLibrary.Services
{
    public interface ICarService
    {
        void CarAlert(Car car, Driver driver);
        Car GetCar();
        Car  CarMoves(Car car);
    }
}