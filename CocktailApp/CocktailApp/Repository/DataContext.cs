using CocktailApp.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CocktailApp.Repository
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
			Database.Migrate();
		}

		public DbSet<CocktailEntity> Cocktails { get; set; }
		public DbSet<BittersEntity> Bitters { get; set; }
		public DbSet<FortifiedWineEntity> FortifiedWines { get; set; }
		public DbSet<SpiritEntity> Spirits { get; set; }

        public DatabaseFacade CurrentDatabase => Database;
    }
}
