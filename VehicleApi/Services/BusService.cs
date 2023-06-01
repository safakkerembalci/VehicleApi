using VehicleApi.Data;
using VehicleApi.Models;

namespace VehicleApi.Services
{
	public class BusService : IBusService
	{
		private readonly IBusRepository busRepository;

		public BusService(IBusRepository busRepository)
		{
			this.busRepository = busRepository;
		}

		public IEnumerable<Bus> GetBusByColor(string color)
		{
			return busRepository.GetBusByColor(color);
		}
	}
}
