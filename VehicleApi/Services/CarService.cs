using VehicleApi.Data;
using VehicleApi.Models;

namespace VehicleApi.Services
{
	public class CarService : ICarService
	{
		private readonly ICarRepository vehicleRepository;

		public CarService(ICarRepository vehicleRepository)
		{
			this.vehicleRepository = vehicleRepository;
		}

		public IEnumerable<Car> GetCarByColor(string color)
		{
			return vehicleRepository.GetCarByColor(color);
		}

		public void TurnOnOffCarHeadlights(int id, bool headlightsOn)
		{
			vehicleRepository.TurnOnOffCarHeadlights(id, headlightsOn);
		}

		public void DeleteCar(int id)
		{
			vehicleRepository.DeleteCar(id);
		}

	}
}
