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
    public class GenreBookRepository : Repository<GenreBook, int>, IGenreBookRepository
    {
        public GenreBookRepository(LibraryDbContext context) : base(context)
        {

        }
    }
}

