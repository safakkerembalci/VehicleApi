using VehicleApi.Models;

namespace VehicleApi.Data
{
	public interface ICarRepository
	{
		IEnumerable<Car> GetCarByColor(string color);

		Car GetCarById(int id);
		void TurnOnOffCarHeadlights(int id, bool headlightsOn);
		void DeleteCar(int id);

	}
}
