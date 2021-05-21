using System.ComponentModel.DataAnnotations;

namespace Shared.Entities.Chapter01
{
	public class Person : Entity
	{
		[Required]
		[MaxLength(50)]
		public string FirstName { get; set; }
		[Required]
		[MaxLength(50)]
		public string LastName { get; set; }
	}
}
