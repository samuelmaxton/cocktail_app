using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CocktailApp.Repository.Entities
{
	[Table("Bitters")]
	public class BittersEntity
	{
		[Key]
		public int BittersId { get; set; }
		public string Name { get; set; }
		[Column(TypeName = "decimal(4,1)")]
		public decimal Abv { get; set; }
		public string Type { get; set; }

		public virtual ICollection<CocktailBittersEntity> CocktailBitters { get; set; }
	}
}
