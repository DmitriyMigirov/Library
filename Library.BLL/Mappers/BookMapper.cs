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
    public class BookMapper : IBookMapper
    {
        private readonly IGenreMapper _genreMapper;
        private readonly IAuthorMapper _authorMapper;

        public BookMapper(IGenreMapper genreMapper, IAuthorMapper authorMapper)
        {
            _genreMapper = genreMapper;
            _authorMapper = authorMapper;
        }

        public Book Map(BookModel from) =>
            new Book()
            {
                Id = from.Id,
                IsBorrowed = from.IsBorrowed,
                Number = from.Number,
                PageCount = from.PageCount,
                ReleaseDate = from.ReleaseDate,
                Title = from.Title,
                Authors = from.Authors.Select(a => _authorMapper.Map(a)).ToList(),
                Genres = from.Genres.Select(g => _genreMapper.Map(g)).ToList()
            };

        public BookModel Map(Book from) =>
            new BookModel()
            {
                Id = from.Id,
                IsBorrowed = from.IsBorrowed,
                Number = from.Number,
                PageCount = from.PageCount,
                ReleaseDate = from.ReleaseDate,
                Title = from.Title,
                Authors = from.Authors.Select(a => _authorMapper.Map(a)).ToList(),
                Genres = from.Genres.Select(g => _genreMapper.Map(g)).ToList()
            };
    }
}
