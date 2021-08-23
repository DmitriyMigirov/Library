using Library.BLL.Mappers.Abstract;
using Library.Entities;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.Mappers
{
    public class ReaderMapper : IReaderMapper
    {
        private readonly IRecordMapper _recordMapper;

        public ReaderMapper(IRecordMapper recordMapper)
        {
            _recordMapper = recordMapper;
        }

        public Reader Map(ReaderModel from) =>
            new Reader()
            {
                Id = from.Id,
                Name = from.Name,
                Parentname = from.Parentname,
                Surname = from.Surname,
                Passport = from.Passport,
                Phone = from.Phone,
                TicketNumber = from.TicketNumber,
                Records = from.Records.Select(r => _recordMapper.Map(r)).ToList()
            };

        public ReaderModel Map(Reader from) =>
            new ReaderModel()
            {
                Id = from.Id,
                Name = from.Name,
                Parentname = from.Parentname,
                Surname = from.Surname,
                Passport = from.Passport,
                Phone = from.Phone,
                TicketNumber = from.TicketNumber,
                Records = from.Records.Select(r => _recordMapper.Map(r)).ToList()
            };
    }
}
