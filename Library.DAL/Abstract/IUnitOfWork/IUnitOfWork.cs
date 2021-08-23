using Library.DAL.Abstract.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Abstract.IUnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IAuthorRepository AuthorRepository { get; }
        IBookAuthorRepository BookAuthorRepository { get; }
        IBookRepository BookRepository { get; }
        IGenreBookRepository GenreBookRepository { get; }
        IGenreRepository GenreRepository { get; }
        IReaderRepository ReaderRepository { get; }
        IRecordRepository RecordRepository { get; }

        void Save();
    }
}
