using VehicleApi.Models;

namespace VehicleApi.Data
{
	public class BusRepository : IBusRepository
	{
		private List<Bus> buses;

		public BusRepository()
		{
			buses = new List<Bus>();

			// Add some sample vehicles to the repository
			buses.Add(new Bus { Color = "red" });
			buses.Add(new Bus { Color = "blue" });
		}

		public IEnumerable<Bus> GetBusByColor(string color)
		{
			return buses.Where(b => b.Color == color);
		}
	}
}
