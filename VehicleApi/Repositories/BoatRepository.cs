using VehicleApi.Models;

namespace VehicleApi.Data
{
	public class BoatRepository : IBoatRepository
	{
		private List<Boat> boats;

		public BoatRepository()
		{
			boats = new List<Boat>();

			// Add some sample vehicles to the repository
			boats.Add(new Boat { Color = "black" });
			boats.Add(new Boat { Color = "white" });
		}

		public IEnumerable<Boat> GetBoatByColor(string color)
		{
			return boats.Where(b => b.Color == color);
		}

	}
}
