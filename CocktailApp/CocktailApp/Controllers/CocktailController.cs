using CocktailApp.Models;
using CocktailApp.Repository.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace CocktailApp.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class SpiritController : ControllerBase
	{
		private readonly ILogger<SpiritController> _logger;
		private readonly ISpiritsRepository _spiritsRepository;

		public SpiritController(ILogger<SpiritController> logger, ISpiritsRepository spiritsRepository)
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
