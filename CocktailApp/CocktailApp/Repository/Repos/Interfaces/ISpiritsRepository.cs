using CocktailApp.Models;

namespace CocktailApp.Repository.Repos.Interfaces
{
	public interface ISpiritsRepository
	{
		Spirit Get(int id);
		Spirit Add(Spirit model);
	}
}