using CocktailApp.Models;
using CocktailApp.Repository.Repos.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CocktailApp.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class SpiritsController : ControllerBase
	{
		private readonly ILogger<SpiritsController> _logger;
		private readonly ISpiritsRepository _spiritsRepository;

		public SpiritsController(ILogger<SpiritsController> logger, ISpiritsRepository spiritsRepository)
		{
			_logger = logger;
			_spiritsRepository = spiritsRepository;
		}

		[HttpGet("{id}")]
		public IActionResult GetSpirit(int id)
		{
			var result = _spiritsRepository.Get(id);
			return Ok(result);
		}

		[HttpPost]
		public IActionResult AddNewSpirit(Spirit spirit)
		{
			spirit.SpiritId = 0;
			var result = _spiritsRepository.Add(spirit);
			return Created(Request.Path + "/" + result.SpiritId, result);
		}
	}
}
