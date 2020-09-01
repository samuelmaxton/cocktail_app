using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CocktailApp.Repository.Entities
{
	[Table("Cocktails")]
	public class CocktailEntity
	{
		[Key]
		public int CocktailId { get; set; }
		public string Name { get; set; }
		public string Recipe { get; set; }
		public DateTime Origin { get; set; }
		public int FortifiedWineId { get; set; }
		public int SpiritId { get; set; }
		public int BittersId { get; set; }

		public virtual FortifiedWineEntity FortifiedWine { get; set; }
		public virtual SpiritEntity Spirit { get; set; }
		public virtual BittersEntity Bitters { get; set; }
	}
}
