using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Record : Base<int>
    {
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public Book Book { get; set; }
        public Reader Reader { get; set; }
        public TimeSpan DurationOfBorrow => (ReturnDate ?? DateTime.Now) - BorrowDate;
    }
}
