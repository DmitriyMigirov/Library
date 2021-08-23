using Library.BLL.Mappers.Abstract;
using Library.BLL.Services.Abstract;
using Library.DAL.Abstract.IUnitOfWork;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.Services
{
    public class ReaderService : IReaderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IReaderMapper _readerMapper;

        public ReaderService(IUnitOfWork unitOfWork, IReaderMapper mapper)
        {
            if (unitOfWork == null || mapper == null)
                throw new ArgumentNullException("Values cannot be null!");
            _unitOfWork = unitOfWork;
            _readerMapper = mapper;
        }

        public ReaderModel GetReaderById(int id)
        {
            var reader = _unitOfWork.ReaderRepository.Get(id);
            return reader == null ? null : _readerMapper.Map(reader);
        }

        public ReaderModel GetReaderByTicketNumber(int ticketNumber)
        {
            var reader = _unitOfWork.ReaderRepository.GetAll().FirstOrDefault(r => r.TicketNumber == ticketNumber);
            return reader == null ? null : _readerMapper.Map(reader);
        }

        public List<ReaderModel> GetReaders()
        {
            return _unitOfWork.ReaderRepository.GetAll().Select(a => _readerMapper.Map(a)).ToList();
        }
    }
}
