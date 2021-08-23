using Library.BLL;
using Library.BLL.Services.Abstract;
using Library.DAL.Dependencies;
using Library.GUI.Commands;
using Library.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Library.GUI
{
    class MainViewModel : INotifyPropertyChanged
    {
        private readonly ServiceProvider _serviceProvider;

        private readonly IBookService _bookService;
        private readonly IReaderService _readerService;
        private readonly IAuthorService _authorService;

        private ICollection<BookModel> _books = new ObservableCollection<BookModel>();
        public ICollection<BookModel> Books => _books;

        private readonly ICommand _findBookByAuthorCommand;
        private readonly ICommand _findBookByTitleCommand;
        private readonly ICommand _findReaderByNumberCommand;
        private readonly ICommand _findBookByNumberCommand;

        public ICommand FindBookByAuthorCommand => _findBookByAuthorCommand;
        public ICommand FindBookByTitleCommand => _findBookByTitleCommand;
        public ICommand FindReaderByNumberCommand => _findReaderByNumberCommand;
        public ICommand FindBookByNumberCommand => _findBookByNumberCommand;

        private BookModel selectedBook;
        public BookModel SelectedBook
        {
            get => selectedBook;
            set
            {
                if (selectedBook != value)
                {
                    selectedBook = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(GenreStr));
                    OnPropertyChanged(nameof(NotesStr));
                }
            }
        }

        
        public string GenreStr
        {
            get
            {
                if (SelectedBook == null)
                    return "Loading...";
                return String.Join(" ", SelectedBook.Genres.Select(g => g.Name));
            }
        }
        public string NotesStr
        {
            get
            {
                if (SelectedBook == null)
                    return "Loading...";
                return SelectedBook.IsBorrowed ? "Borrowed" : "Returned";
            }
        }

        public MainViewModel()
        {
            var serviceColl = new ServiceCollection();
            serviceColl.RegisterServices();
            serviceColl.RegisterDependencies();
            _serviceProvider = serviceColl.BuildServiceProvider();

            _bookService = _serviceProvider.GetRequiredService<IBookService>();
            _readerService = _serviceProvider.GetRequiredService<IReaderService>();
            _authorService = _serviceProvider.GetRequiredService<IAuthorService>();

            _findBookByAuthorCommand = new DelegateCommand(findBookByAuthor);
            _findBookByTitleCommand = new DelegateCommand(findBookByTitle);
            _findReaderByNumberCommand = new DelegateCommand(findReaderByNumber);
            _findBookByNumberCommand = new DelegateCommand(findBookByNumber);

            loadBooks();
        }

        private void loadBooks()
        {
            _books.Clear();
            foreach (var item in _bookService.GetBooks())
            {
                _books.Add(item);
            }
            if (_books.Count != 0)
                SelectedBook = _books.ElementAt(0);
        }

        private void findBookByNumber()
        {
            MessageBox.Show("findBookByNumber!");
        }

        private void findReaderByNumber()
        {
            MessageBox.Show("findReaderByNumber!");
        }

        private void findBookByTitle()
        {
            MessageBox.Show("findBookByTitle!");
        }

        private void findBookByAuthor()
        {
            MessageBox.Show("findBookByAuthor!");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
