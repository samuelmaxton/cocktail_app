﻿using CocktailApp.Models;
using CocktailApp.Repository.Entities;
using CocktailApp.Repository.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CocktailApp.Repository.Repos
{
	public class CocktailsRepository : ICocktailsRepository
	{
		private readonly DataContext _dataContext;

		public CocktailsRepository(DataContext dataContext)
		{
			_dataContext = dataContext;
		}

		public Cocktail Add(Cocktail model)
		{
			var entity = CocktailEntity.Map(model);
			var newCocktail = _dataContext.Cocktails.Add(entity).Entity;
			_dataContext.SaveChanges();
			return CocktailEntity.Map(newCocktail);
		}

		public Cocktail Get(int id)
		{
			var entity = _dataContext.Cocktails
				.Include(c => c.CocktailBitters)
				.SingleOrDefault(c => c.CocktailId == id);

			return entity == null ? null : CocktailEntity.Map(entity);
		}
	}
}
