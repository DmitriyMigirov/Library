using Library.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace Library.DAL.EF
{
    public class LibraryDbContext : DbContext
    {

        public LibraryDbContext()
            : base("name=LibraryDbContext")
        {
            Database.SetInitializer(new LibraryDbInitializer());
        }

         public virtual DbSet<Book> Books { get; set; }
         public virtual DbSet<Author> Authors { get; set; }
         public virtual DbSet<Genre> Genres { get; set; }
         public virtual DbSet<Reader> Readers { get; set; }
         public virtual DbSet<Record> Records { get; set; }
         public virtual DbSet<GenreBook> GenreBooks { get; set; }
         public virtual DbSet<BookAuthor> BookAuthors { get; set; }
    }
}