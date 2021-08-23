using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.Services.Abstract
{
    public interface IBookService
    {
        List<BookModel> GetBooks();
        List<BookModel> GetBooksByTitle(string title);
        List<BookModel> GetBooksByAuthorId(int authorId);
        BookModel GetBookByNumber(int number);
    }
}
