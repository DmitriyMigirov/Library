using Library.BLL.Mappers;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.Services.Abstract
{
    public interface IReaderService
    {
        List<ReaderModel> GetReaders();
        ReaderModel GetReaderById(int id);
        ReaderModel GetReaderByTicketNumber(int ticketNumber);
    }
}
