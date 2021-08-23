using Library.Models.Abstract;

namespace Library.Models
{
    public class GenreModel : BaseModel
    {
        #region Fields
        private int _id;
        private string _name;
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
        #endregion
    }
}