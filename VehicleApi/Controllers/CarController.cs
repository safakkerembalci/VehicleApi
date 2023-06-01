using Microsoft.AspNetCore.Mvc;
using VehicleApi.Models;
using VehicleApi.Services;

namespace VehicleApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CarController : ControllerBase
	{
		private readonly ICarService carService;

		public CarController(ICarService carService)
		{
			this.carService = carService;
		}

		[HttpGet("cars")]
		public ActionResult<IEnumerable<Car>> GetCarsByColor(string color)
		{
			var cars = carService.GetCarByColor(color);
			return Ok(cars);
		}

		[HttpPost("cars/{id}/headlights")]
		public ActionResult TurnOnOffCarHeadlights(int id, [FromBody] bool headlightsOn)
		{
			carService.TurnOnOffCarHeadlights(id, headlightsOn);
			return NoContent();
		}

		[HttpDelete("cars/{id}")]
		public ActionResult DeleteCar(int id)
		{
			carService.DeleteCar(id);
			return NoContent();
		}

	}
}
