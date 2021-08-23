using Library.BLL.Mappers.Abstract;
using Library.BLL.Services.Abstract;
using Library.DAL.Abstract.IUnitOfWork;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.Services
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBookMapper _bookMapper;

        public BookService(IUnitOfWork unitOfWork, IBookMapper mapper)
        {
            if (unitOfWork == null || mapper == null)
                throw new ArgumentNullException("Values cannot be null!");
            _unitOfWork = unitOfWork;
            _bookMapper = mapper;
        }

        public BookModel GetBookByNumber(int number)
        {
            var book = _unitOfWork.BookRepository.GetAll().FirstOrDefault(r => r.Number == number);
            return book == null ? null : _bookMapper.Map(book);
        }

        public List<BookModel> GetBooks()
        {
            return _unitOfWork.BookRepository.GetAll().Select(a => _bookMapper.Map(a)).ToList();
        }

        public List<BookModel> GetBooksByAuthorId(int authorId)
        {
            var books = _unitOfWork.BookRepository.GetAll().Where(r => r.Authors.FirstOrDefault(a => a.Id == authorId) != null);
            return books.Select(b => _bookMapper.Map(b)).ToList();
        }

        List<BookModel> IBookService.GetBooksByTitle(string title)
        {
            var books = _unitOfWork.BookRepository.GetAll().Where(r => r.Title == title);
            return books.Select(b => _bookMapper.Map(b)).ToList();
        }
    }
}
