using VehicleApi.Models;

namespace VehicleApi.Data
{
	public interface IBoatRepository
	{
		IEnumerable<Boat> GetBoatByColor(string color);

	}
}
