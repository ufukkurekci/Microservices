using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rezervation.API.Infrastructure;

namespace Rezervation.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ResarvationController : ControllerBase
	{
		private IReservation _reservation;

		public ResarvationController(IReservation reservation)
		{
			_reservation = reservation;
		}

		[HttpGet("{Id}")]
		public IActionResult Get(int Id)
		{
			return Ok(_reservation.GetResByBkgNumber(Id));
		}
	}
}
