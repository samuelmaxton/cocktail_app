using CocktailApp.Models;
using CocktailApp.Repository.Repos.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CocktailApp.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class FortifiedWinesController : ControllerBase
	{
		private readonly ILogger<FortifiedWinesController> _logger;
		private readonly IFortifiedWinesRepository _fortifiedWinesRepository;

		public FortifiedWinesController(ILogger<FortifiedWinesController> logger, IFortifiedWinesRepository fortifiedWinesRepository)
		{
			_logger = logger;
			_fortifiedWinesRepository = fortifiedWinesRepository;
		}

		[HttpGet("{id}")]
		public IActionResult GetFortifiedWine(int id)
		{
			var result = _fortifiedWinesRepository.Get(id);
			return Ok(result);
		}

		[HttpPost]
		public IActionResult AddNewFortifiedWine(FortifiedWine fortifiedWine)
		{
			fortifiedWine.FortifiedWineId = 0;
			var result = _fortifiedWinesRepository.Add(fortifiedWine);
			return Created(Request.Path + "/" + result.FortifiedWineId, result);
		}
	}
}
