using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Base<TKey>
    {
        public TKey Id { get; set; }
    }
}
