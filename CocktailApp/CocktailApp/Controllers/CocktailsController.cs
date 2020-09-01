using CocktailApp.Models;
using CocktailApp.Repository.Repos.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CocktailApp.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CocktailsController : ControllerBase
	{
		private readonly ILogger<CocktailsController> _logger;
		private readonly ICocktailsRepository _cocktailsRepository;

		public CocktailsController(ILogger<CocktailsController> logger, ICocktailsRepository cocktailsRepository)
		{
			_logger = logger;
			_cocktailsRepository = cocktailsRepository;
		}

		[HttpGet("{id}")]
		public IActionResult GetCocktail(int id)
		{
			var result = _cocktailsRepository.Get(id);
			return Ok(result);
		}

		[HttpPost]
		public IActionResult AddNewCocktail(Cocktail cocktail)
		{
			cocktail.CocktailId = 0;
			var result = _cocktailsRepository.Add(cocktail);
			return Created(Request.Path + "/" + result.CocktailId, result);
		}
	}
}
