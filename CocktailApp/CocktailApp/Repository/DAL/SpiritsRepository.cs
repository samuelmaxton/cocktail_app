using CocktailApp.Models;
using CocktailApp.Repository.Entities;

namespace CocktailApp.Repository.DAL
{
	public class SpiritsRepository : ISpiritsRepository
	{
		private readonly DataContext _dataContext;

		public SpiritsRepository(DataContext dataContext)
		{
			_dataContext = dataContext;
		}

		public Spirit Add(Spirit model)
		{
			var entity = SpiritEntity.Map(model);
			var newSpirit = _dataContext.Spirits.Add(entity).Entity;
			_dataContext.SaveChanges();
			return SpiritEntity.Map(newSpirit);
		}

		public Spirit Get(int id)
		{
			var entity = _dataContext.Spirits.Find(id);
			return entity == null ? null : SpiritEntity.Map(entity);
		}
	}
}
