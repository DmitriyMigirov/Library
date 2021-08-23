using Library.Models.Abstract;

namespace Library.Models
{
    public class AuthorModel : BaseModel
    {
        #region Fields
        private int _id;
        private string _name;
        private string _surname;
        private string _parentname;
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
        #endregion

        public override string ToString()
        {
            return $"[{Id}] -> {Surname} {Name} {Parentname}";
        }

    }
}