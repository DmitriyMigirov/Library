using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Abstract.IRepositories
{
    public interface IRecordRepository : IRepository<Record, int>
    {
        List<Book> GetReturnedBooks();

        List<Book> GetCurrentlyBorrowedBooks();
    }
}
