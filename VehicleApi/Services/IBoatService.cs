using VehicleApi.Models;

namespace VehicleApi.Services
{
	public interface IBoatService
	{
		IEnumerable<Boat> GetBoatByColor(string color);
	}
}
