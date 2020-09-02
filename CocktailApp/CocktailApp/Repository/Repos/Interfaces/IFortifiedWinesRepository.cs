using CocktailApp.Models;

namespace CocktailApp.Repository.Repos.Interfaces
{
	public interface IFortifiedWinesRepository
	{
		FortifiedWine Get(int id);
		FortifiedWine Add(FortifiedWine model);
	}
}
