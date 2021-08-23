using Library.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class RecordModel : BaseModel
    {
        #region Fields
        private int _id;
        private DateTime _borrowDate;
        private DateTime? _returnDate;
        private BookModel _book;
        private ReaderModel _reader;
        #endregion

        #region Properties
        public int Id
        {
            get => _id;
            set
            {
                if (value != _id)
                {
                    _id = value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTime BorrowDate
        {
            get => _borrowDate;
            set
            {
                if (value != _borrowDate)
                {
                    _borrowDate = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(DurationOfBorrow));
                }
            }
        }
        public DateTime? ReturnDate
        {
            get => _returnDate;
            set
            {
                if (value != _returnDate)
                {
                    _returnDate = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(DurationOfBorrow));
                }
            }
        }
        public BookModel Book
        {
            get => _book;
            set
            {
                if (value != _book)
                {
                    _book = value;
                    OnPropertyChanged();
                }
            }
        }
        public ReaderModel Reader
        {
            get => _reader;
            set
            {
                if (value != _reader)
                {
                    _reader = value;
                    OnPropertyChanged();
                }
            }
        }
        public TimeSpan DurationOfBorrow => (ReturnDate ?? DateTime.Now) - BorrowDate;

        #endregion


    }
}
