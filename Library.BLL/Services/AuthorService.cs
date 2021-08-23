using Library.BLL.Mappers;
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
    public class AuthorService : IAuthorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthorMapper _authorMapper;

        public AuthorService(IUnitOfWork unitOfWork, IAuthorMapper mapper)
        {
            if (unitOfWork == null || mapper == null)
                throw new ArgumentNullException("Values cannot be null!");
            _unitOfWork = unitOfWork;
            _authorMapper = mapper;
        }

        public List<AuthorModel> GetAuthors()
        {
            return _unitOfWork.AuthorRepository.GetAll().Select(a => _authorMapper.Map(a)).ToList();
        }
    }
}
