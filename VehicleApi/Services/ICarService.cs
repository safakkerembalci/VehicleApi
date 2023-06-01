using VehicleApi.Models;

namespace VehicleApi.Services
{
	public interface ICarService
	{
		IEnumerable<Car> GetCarByColor(string color);
		void DeleteCar(int id);
		void TurnOnOffCarHeadlights(int id, bool headlightsOn);
	}
}
