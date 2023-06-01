using VehicleApi.Models;

namespace VehicleApi.Data
{
	public interface IBusRepository
	{
		IEnumerable<Bus> GetBusByColor(string color);

	}
}
