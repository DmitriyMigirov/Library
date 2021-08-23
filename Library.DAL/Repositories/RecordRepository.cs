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
    public class RecordRepository : Repository<Record, int>, IRecordRepository
    {
        public RecordRepository(LibraryDbContext context) : base(context)
        {

        }
        public List<Book> GetReturnedBooks()
        {
            return _dbSet.Where(r => !r.Book.IsBorrowed).Select(b => b.Book).ToList();
        }

        public List<Book> GetCurrentlyBorrowedBooks()
        {
            return _dbSet.Where(r => r.Book.IsBorrowed).Select(b => b.Book).ToList();
        }
    }
}
