using Library.Models;
using Library.Models.Abstract;
using System;
using System.Collections.Generic;

namespace Library.Models
{
    public class BookModel : BaseModel
    {
        #region Fields

        private int _id;
        private string _title;
        private int _pageCount;
        private DateTime _releaseDate;
        private bool _isBorrowed;
        private int _number;
        private List<AuthorModel> _authors;
        private List<GenreModel> _genres;
        #endregion

        #region Properties
        public int Id
        {
            get => _id;
            set 
            { 
                if(value != _id)
                {
                    _id = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Title
        {
            get => _title;
            set
            {
                if (value != _title)
                {
                    _title = value;
                    OnPropertyChanged();
                }
            }
        }
        public int PageCount
        {
            get => _pageCount;
            set
            {
                if (value != _pageCount)
                {
                    _pageCount = value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTime ReleaseDate
        {
            get => _releaseDate;
            set
            {
                if (value != _releaseDate)
                {
                    _releaseDate = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsBorrowed
        {
            get => _isBorrowed;
            set
            {
                if (value != _isBorrowed)
                {
                    _isBorrowed = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Number
        {
            get => _number;
            set
            {
                if (value != _number)
                {
                    _number = value;
                    OnPropertyChanged();
                }
            }
        }

        public List<AuthorModel> Authors
        {
            get => _authors;
            set
            {
                if (value != _authors)
                {
                    _authors = value;
                    OnPropertyChanged();
                }
            }
        }

        public List<GenreModel> Genres
        {
            get => _genres;
            set
            {
                if (value != _genres)
                {
                    _genres = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        public override string ToString()
        {
            return $"{Title} с #{Number} номером была выпущена {ReleaseDate}";
        }
    }
}
