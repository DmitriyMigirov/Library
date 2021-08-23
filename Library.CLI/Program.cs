using Library.BLL.Mappers;
using Library.BLL.Services;
using Library.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            new ConsoleApplication().Execute();
        }
    }
}
