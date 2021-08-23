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
    public class GenreMapper : IGenreMapper
    {
        public Genre Map(GenreModel from) =>
            new Genre()
            {
                Id = from.Id,
                Name = from.Name
            };

        public GenreModel Map(Genre from) =>
            new GenreModel()
            {
                Id = from.Id,
                Name = from.Name
            };
    }
}
