using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Author : Base<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Parentname { get; set; }
    }
}
