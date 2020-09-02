using CocktailApp.Models;
using CocktailApp.Repository.Entities;
using CocktailApp.Repository.Repos.Interfaces;

namespace CocktailApp.Repository.Repos
{
	public class FortifiedWinesRepository : IFortifiedWinesRepository
	{
		private readonly DataContext _dataContext;

		public FortifiedWinesRepository(DataContext dataContext)
		{
			_dataContext = dataContext;
		}

		public FortifiedWine Add(FortifiedWine model)
		{
			var entity = FortifiedWineEntity.Map(model);
			var newFortifiedWine = _dataContext.FortifiedWines.Add(entity).Entity;
			_dataContext.SaveChanges();
			return FortifiedWineEntity.Map(newFortifiedWine);
		}

		public FortifiedWine Get(int id)
		{
			var entity = _dataContext.FortifiedWines.Find(id);
			return entity == null ? null : FortifiedWineEntity.Map(entity);
		}
	}
}
