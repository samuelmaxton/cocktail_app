using CocktailApp.Models;

namespace CocktailApp.Repository.Repos.Interfaces
{
	public interface ICocktailsRepository
	{
		Cocktail Get(int id);
		Cocktail Add(Cocktail model);
	}
}
