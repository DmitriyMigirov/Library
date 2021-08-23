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
    public class RecordMapper : IRecordMapper
    {
        private readonly IBookMapper _bookMapper;

        public RecordMapper(IBookMapper bookMapper)
        {
            _bookMapper = bookMapper;
        }

        public Record Map(RecordModel from)
        {
            var record = new Record()
            {
                Id = from.Id,
                Book = _bookMapper.Map(from.Book),
                BorrowDate = from.BorrowDate,
                ReturnDate = from.ReturnDate
            };
            Reader reader = new Reader()
            {
                Id = from.Reader.Id,
                Name = from.Reader.Name,
                Parentname = from.Reader.Parentname,
                Surname = from.Reader.Surname,
                Passport = from.Reader.Passport,
                Phone = from.Reader.Phone,
                TicketNumber = from.Reader.TicketNumber,
                Records = from.Reader.Records.Select(r => Map(r)).ToList()
            };
            record.Reader = reader;
            return record;
        }
            
        

        public RecordModel Map(Record from)
        {
            var record = new RecordModel()
            {
                Id = from.Id,
                Book = _bookMapper.Map(from.Book),
                BorrowDate = from.BorrowDate,
                ReturnDate = from.ReturnDate
            };
            ReaderModel reader = new ReaderModel()
            {
                Id = from.Reader.Id,
                Name = from.Reader.Name,
                Parentname = from.Reader.Parentname,
                Surname = from.Reader.Surname,
                Passport = from.Reader.Passport,
                Phone = from.Reader.Phone,
                TicketNumber = from.Reader.TicketNumber,
                Records = from.Reader.Records.Select(r => Map(r)).ToList()
            };
            record.Reader = reader;
            return record;
        }
    }
}
