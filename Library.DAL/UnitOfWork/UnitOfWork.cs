using Library.DAL.Abstract.IRepositories;
using Library.DAL.Abstract.IUnitOfWork;
using Library.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LibraryDbContext _context;
        private bool _isDisposed;

        public IAuthorRepository AuthorRepository { get; }
        public IBookAuthorRepository BookAuthorRepository { get; }
        public IBookRepository BookRepository { get; }
        public IGenreBookRepository GenreBookRepository { get; }
        public IGenreRepository GenreRepository { get; }
        public IReaderRepository ReaderRepository { get; }
        public IRecordRepository RecordRepository { get; }


        public UnitOfWork(
            LibraryDbContext context,
            IAuthorRepository authorRepository,
            IBookAuthorRepository bookAuthorRepository,
            IBookRepository bookRepository,
            IGenreBookRepository genreBookRepository,
            IGenreRepository genreRepository,
            IReaderRepository readerRepository,
            IRecordRepository recordRepository)
        {
            _context = context;
            AuthorRepository = authorRepository;
            BookAuthorRepository = bookAuthorRepository;
            BookRepository = bookRepository;
            GenreBookRepository = genreBookRepository;
            GenreRepository = genreRepository;
            ReaderRepository = readerRepository;
            RecordRepository = recordRepository;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        ~UnitOfWork() 
        { 
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_isDisposed) { return; }
            if (disposing) { _context.Dispose(); }
            _isDisposed = true;
        }
    }
}
