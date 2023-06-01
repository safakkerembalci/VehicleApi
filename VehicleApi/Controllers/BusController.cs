using Microsoft.AspNetCore.Mvc;
using VehicleApi.Models;
using VehicleApi.Services;

namespace VehicleApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class BusController : ControllerBase
	{
		private readonly IBusService busService;

		public BusController(IBusService busService)
		{
			this.busService = busService;
		}

		[HttpGet("buses")]
		public ActionResult<IEnumerable<Bus>> GetBusesByColor(string color)
		{
			var buses = busService.GetBusByColor(color);
			return Ok(buses);
		}
	}
}
