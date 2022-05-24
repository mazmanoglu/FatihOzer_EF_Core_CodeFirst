using FatihOzer_EF_Core_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace FatihOzer_EF_Core_CodeFirst.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Student>()
				.HasData(
					new Student { StudentId = 1, FirstName = "Fatih", LastName = "Ozer" },
					new Student { StudentId = 2, FirstName = "Anass", LastName = "Allamzi" },
					new Student { StudentId = 3, FirstName = "Olga", LastName = "Kharchuk" }
				);
			modelBuilder.Entity<Book>()
				.HasData(
					new Book { BookId = 1, Title = "basics of maths", Published = new DateTime(1980, 02, 02), StudentId = 1 },
					new Book { BookId = 2, Title = "csharp examples", Published = new DateTime(2010, 01, 04), StudentId = 1 },
					new Book { BookId = 3, Title = "dependency injection in dotnet", Published = new DateTime(2015, 06, 11), StudentId = 3 }
				);
			modelBuilder.Entity<Author>()
				.HasData(
					new Author { AuthorId = 1, Name = "Kenan", SurName = "Kurda" },
					new Author { AuthorId = 2, Name = "Pearl", SurName = "De Smet" },
					new Author { AuthorId = 3, Name = "Ruud", SurName = "Marks" }
				);

			modelBuilder.Entity<AuthorBook>()
				.HasData(
					new AuthorBook { AuthorBookId = 1, AuthorId = 1, BookId = 1 },
					new AuthorBook { AuthorBookId = 2, AuthorId = 2, BookId = 2 },
					new AuthorBook { AuthorBookId = 3, AuthorId = 3, BookId = 3 },
					new AuthorBook { AuthorBookId = 4, AuthorId = 1, BookId = 2 }
				);

			// many to many keys
			modelBuilder.Entity<AuthorBook>()
				.HasKey(ab => new { ab.BookId, ab.AuthorId });

			// one to many  authorbook --> book
			modelBuilder.Entity<AuthorBook>()
				.HasOne<Book>(ab => ab.Book)
				.WithMany(b => b.AuthorBooks)
				.HasForeignKey(b => b.BookId);

			// one to many  authorbook --> author
			modelBuilder.Entity<AuthorBook>()
				.HasOne<Author>(ab => ab.Author)
				.WithMany(b => b.AuthorBooks)
				.HasForeignKey(b => b.AuthorId);
		}

		public DbSet<Student> Students { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<Author> Authors { get; set; }
		public DbSet<AuthorBook> AuthorBooks { get; set; }

	}
}
