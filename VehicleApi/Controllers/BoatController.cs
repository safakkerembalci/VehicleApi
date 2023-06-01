using Microsoft.AspNetCore.Mvc;
using VehicleApi.Models;
using VehicleApi.Services;

namespace VehicleApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class BoatController : ControllerBase
	{
		private readonly IBoatService boatService;

		public BoatController(IBoatService boatService)
		{
			this.boatService = boatService;
		}

		[HttpGet("boats")]
		public ActionResult<IEnumerable<Boat>> GetBoatsByColor(string color)
		{
			var boats = boatService.GetBoatByColor(color);
			return Ok(boats);
		}
	}
}
