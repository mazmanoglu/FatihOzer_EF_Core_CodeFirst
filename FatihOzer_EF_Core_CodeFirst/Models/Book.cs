using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FatihOzer_EF_Core_CodeFirst.Models
{
	public class Book
	{
		public int BookId { get; set; }
		[Required]
		[MaxLength(100)]
		public string Title { get; set; }
		[Required]
		public DateTime Published { get; set; }

		public int StudentId { get; set; }
		public virtual Student Student { get; set; }

		public ICollection<AuthorBook> AuthorBooks { get; set; }
	}
}
