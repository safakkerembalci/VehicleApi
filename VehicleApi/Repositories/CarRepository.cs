using VehicleApi.Models;

namespace VehicleApi.Data
{
	public class CarRepository : ICarRepository
	{
		private List<Car> cars;

		public CarRepository()
		{
			cars = new List<Car>();

			// Add some sample vehicles to the repository
			cars.Add(new Car { Color = "red", Wheels = 4, HeadlightsOn = false });
			cars.Add(new Car { Color = "blue", Wheels = 4, HeadlightsOn = true });
			cars.Add(new Car { Color = "black", Wheels = 4, HeadlightsOn = false });
			cars.Add(new Car { Color = "white", Wheels = 4, HeadlightsOn = true });
		}

		public IEnumerable<Car> GetCarByColor(string color)
		{
			return cars.Where(c => c.Color == color);
		}

		public Car GetCarById(int id)
		{
			return cars.FirstOrDefault(c => c.Id == id);
		}

		public void TurnOnOffCarHeadlights(int id, bool headlightsOn)
		{
			var car = cars.FirstOrDefault(c => c.Id == id);
			if (car != null)
			{
				car.HeadlightsOn = headlightsOn;
			}
		}

		public void DeleteCar(int id)
		{
			var car = cars.FirstOrDefault(c => c.Id == id);
			if (car != null)
			{
				cars.Remove(car);
			}
		}
	}
}
