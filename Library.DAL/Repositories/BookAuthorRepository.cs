using Library.DAL.Abstract.IRepositories;
using Library.DAL.EF;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Repositories
{
    public class BookAuthorRepository : Repository<BookAuthor, int>, IBookAuthorRepository
    {
        public BookAuthorRepository(LibraryDbContext context) : base(context)
        {

        }
    }
}
