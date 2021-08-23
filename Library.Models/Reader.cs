using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Reader : Base<int>
    {
        public Reader()
        {
            Records = new List<Record>();
        }
        public int TicketNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Parentname { get; set; }
        public string Passport { get; set; }
        public string Phone { get; set; }
        public List<Record> Records { get; set; }

        public List<Book> GetReturnedBooks()
        {
            return Records.Where(r => !r.Book.IsBorrowed).Select(b => b.Book).ToList();
        }

        public List<Book> GetCurrentlyBorrowedBooks()
        {
            return Records.Where(r => r.Book.IsBorrowed).Select(b => b.Book).ToList();
        }
    }
}
