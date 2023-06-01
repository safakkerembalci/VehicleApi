using VehicleApi.Models;

namespace VehicleApi.Services
{
	public interface IBusService
	{
		IEnumerable<Bus> GetBusByColor(string color);
	}
}
