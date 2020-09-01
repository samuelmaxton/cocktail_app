using CocktailApp.Models;

namespace CocktailApp.Repository.DAL
{
	public interface ISpiritsRepository
	{
		Spirit Get(int id);
		Spirit Add(Spirit model);
	}
}