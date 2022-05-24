﻿namespace FatihOzer_EF_Core_CodeFirst.Models
{
	public class AuthorBook
	{
		public int AuthorBookId { get; set; }


		public int AuthorId { get; set; }
		public virtual Author Author { get; set; }


		public int BookId { get; set; }
		public virtual Book Book { get; set; }
	}
}
