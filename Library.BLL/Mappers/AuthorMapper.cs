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
    public class AuthorMapper : IAuthorMapper
    {
        public Author Map(AuthorModel from) =>
            new Author()
            {
                Id = from.Id,
                Name = from.Name,
                Parentname = from.Parentname,
                Surname = from.Surname
            };

        public AuthorModel Map(Author from) =>
            new AuthorModel()
            {
                Id = from.Id,
                Name = from.Name,
                Parentname = from.Parentname,
                Surname = from.Surname
            };
    }
}
