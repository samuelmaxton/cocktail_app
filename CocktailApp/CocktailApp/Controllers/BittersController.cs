using CocktailApp.Models;
using CocktailApp.Repository.Repos.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CocktailApp.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class BittersController : ControllerBase
	{
		private readonly ILogger<BittersController> _logger;
		private readonly IBittersRepository _bittersRepository;

		public BittersController(ILogger<BittersController> logger, IBittersRepository bittersRepository)
		{
			_logger = logger;
			_bittersRepository = bittersRepository;
		}

		[HttpGet("{id}")]
		public IActionResult GetBitters(int id)
		{
			var result = _bittersRepository.Get(id);
			return Ok(result);
		}

		[HttpPost]
		public IActionResult AddNewBitters(Bitters bitters)
		{
			bitters.BittersId = 0;
			var result = _bittersRepository.Add(bitters);
			return Created(Request.Path + "/" + result.BittersId, result);
		}
	}
}
