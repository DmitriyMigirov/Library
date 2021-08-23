using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Book : Base<int>
    {
        public Book()
        {
            Authors = new List<Author>();
            Genres = new List<Genre>();
        }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsBorrowed { get; set; }
        public int Number { get; set; }
        public List<Author> Authors { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
