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
    public class ReaderRepository : Repository<Reader, int>, IReaderRepository
    {
        public ReaderRepository(LibraryDbContext context) : base(context)
        {

        }
    }
}

