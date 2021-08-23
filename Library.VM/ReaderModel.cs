using Library.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class ReaderModel : BaseModel
    {
        #region Fields
        private int _id;
        private int _ticketNumber;
        private string _name;
        private string _surname;
        private string _parentname;
        private string _passport;
        private string _phone;
        private List<RecordModel> _records;
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
        public string Name
        {
            get => _name;
            set
            {
                if (value != _name)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Surname
        {
            get => _surname;
            set
            {
                if (value != _surname)
                {
                    _surname = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Parentname
        {
            get => _parentname;
            set
            {
                if (value != _parentname)
                {
                    _parentname = value;
                    OnPropertyChanged();
                }
            }
        }
        public int TicketNumber
        {
            get => _ticketNumber;
            set
            {
                if (value != _ticketNumber)
                {
                    _ticketNumber = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Passport
        {
            get => _passport;
            set
            {
                if (value != _passport)
                {
                    _passport = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Phone
        {
            get => _phone;
            set
            {
                if (value != _phone)
                {
                    _phone = value;
                    OnPropertyChanged();
                }
            }
        }
        public List<RecordModel> Records
        {
            get => _records;
            set
            {
                if (value != _records)
                {
                    _records = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        public List<BookModel> GetReturnedBooks()
        {
            return Records.Where(r => r.ReturnDate != null).Select(b => b.Book).ToList();
        }

        public List<BookModel> GetCurrentlyBorrowedBooks()
        {
            return Records.Where(r => r.ReturnDate == null).Select(b => b.Book).ToList();
        }

        public override string ToString()
        {
            return $"{Surname} {Name} {Parentname} [{Phone}]";
        }
    }
}
