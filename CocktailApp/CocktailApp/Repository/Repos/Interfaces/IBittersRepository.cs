using CocktailApp.Models;

namespace CocktailApp.Repository.Repos.Interfaces
{
	public interface IBittersRepository
	{
		Bitters Get(int id);
		Bitters Add(Bitters model);
	}
}
