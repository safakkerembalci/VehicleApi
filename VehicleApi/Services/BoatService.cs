using VehicleApi.Data;
using VehicleApi.Models;

namespace VehicleApi.Services
{
	public class BoatService : IBoatService
	{
		private readonly IBoatRepository boatRepository;

		public BoatService(IBoatRepository boatRepository)
		{
			this.boatRepository = boatRepository;
		}

		public IEnumerable<Boat> GetBoatByColor(string color)
		{
			return boatRepository.GetBoatByColor(color);
		}

	}
}
