using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FatihOzer_EF_Core_CodeFirst.Models
{
	public class Student
	{
		public int StudentId { get; set; }
		[MaxLength(30)]
		[Required]
		public string FirstName { get; set; }
		[MaxLength(30)]
		[Required]
		public string LastName { get; set; }

		public virtual ICollection<Book> Books { get; set; }
	}
}
