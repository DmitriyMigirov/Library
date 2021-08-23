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
    public class BookRepository : Repository<Book, int>, IBookRepository
    {
        public BookRepository(LibraryDbContext context) : base(context)
        {

        }
    }
}

