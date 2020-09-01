﻿using CocktailApp.Models;
using CocktailApp.Repository.Entities;
using CocktailApp.Repository.Repos.Interfaces;

namespace CocktailApp.Repository.Repos
{
	public class BittersRepository : IBittersRepository
	{
		private readonly DataContext _dataContext;

		public BittersRepository(DataContext dataContext)
		{
			_dataContext = dataContext;
		}

		public Bitters Add(Bitters model)
		{
			var entity = BittersEntity.Map(model);
			var newBitters = _dataContext.Bitters.Add(entity).Entity;
			_dataContext.SaveChanges();
			return BittersEntity.Map(newBitters);
		}

		public Bitters Get(int id)
		{
			var entity = _dataContext.Bitters.Find(id);
			return entity == null ? null : BittersEntity.Map(entity);
		}
	}
}
