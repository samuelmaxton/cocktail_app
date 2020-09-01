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
		public DbSet<CocktailBittersEntity> CocktailBitters { get; set; }

        public DatabaseFacade CurrentDatabase => Database;

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Many-To-Many Relationship must be done using Fluent Api until EF Core 5 is released
			modelBuilder.Entity<CocktailBittersEntity>().HasKey(cb => new { cb.CocktailId, cb.BittersId });
		}
	}
}
