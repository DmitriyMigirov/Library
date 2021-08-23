using Library.BLL;
using Library.BLL.Services.Abstract;
using Library.DAL.Dependencies;
using Library.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library.CLI
{
    class ConsoleApplication
    {
        private readonly ServiceProvider serviceProvider;

        private readonly IBookService _bookService;
        private readonly IReaderService _readerService;
        private readonly IAuthorService _authorService;

        public ConsoleApplication()
        {
            var serviceColl = new ServiceCollection();
            serviceColl.RegisterServices();
            serviceColl.RegisterDependencies();
            serviceProvider = serviceColl.BuildServiceProvider();

            _bookService = serviceProvider.GetRequiredService<IBookService>();
            _readerService = serviceProvider.GetRequiredService<IReaderService>();
            _authorService = serviceProvider.GetRequiredService<IAuthorService>();
        }

        public void Execute()
        {
            Console.WriteLine("Загрузка...");
            _bookService.GetBooksByAuthorId(1);
            Console.Clear();

            string selector;

            do
            {
                Console.Write("[1] - Найти клиента по номеру читательского билета\n" +
                                  "[2] - Найти книгу по библиотечному номеру\n" +
                                  "[3] - Найти книги (название/автор)\n" +
                                  "[4] - Просмотреть книги клиента \n" +
                                  "[0] - Выход\n" +
                                  "Введите ваш выбор: ");
                selector = Console.ReadLine();
                Console.Clear();
                switch (selector)
                {
                    case "0":
                        Console.WriteLine("Завершение...");
                        Thread.Sleep(500);
                        return;
                    case "1":
                        {
                            ReaderModel reader;
                            try
                            {
                                reader = getReaderByNumber();
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                                break;
                            }
                            if (reader == null)
                            {
                                Console.WriteLine($"Данный клиент не был найден");
                                break;
                            }
                            Console.WriteLine(reader.ToString());
                            break;
                        }
                    case "2":
                        {
                            Console.Write("Введите номер: ");
                            string numberStr = Console.ReadLine();

                            if (!int.TryParse(numberStr, out int number))
                            {
                                Console.WriteLine("Номер должен содержать только цифры!");
                                break;
                            }

                            var book = _bookService.GetBookByNumber(number);
                            if (book == null)
                            {
                                Console.WriteLine($"Книга по {number} номеру не была найдена");
                                break;
                            }
                            Console.WriteLine(book.ToString());
                            break;
                        }
                    case "3":
                        {
                            string subSelector;
                            Console.Write("[1] - Найти книги по названию\n" +
                                     "[2] - Найти книги по автору\n" +
                                     "Введите ваш выбор: ");
                            subSelector = Console.ReadLine();
                            switch (subSelector)
                            {
                                case "1":
                                    {
                                        Console.Write("Введите название: ");
                                        string title = Console.ReadLine();
                                        var books = _bookService.GetBooksByTitle(title);

                                        if (books.Count == 0)
                                        {
                                            Console.WriteLine($"Книги с названием {title} не были найдены.");
                                            break;
                                        }

                                        foreach (var b in books)
                                        {
                                            Console.WriteLine(b.ToString());
                                        }

                                        break;
                                    }
                                case "2":
                                    {
                                        foreach (var a in _authorService.GetAuthors())
                                        {
                                            Console.WriteLine(a.ToString());
                                        }
                                        Console.Write("Введите id автора: ");
                                        string numberStr = Console.ReadLine();

                                        if (!int.TryParse(numberStr, out int number))
                                        {
                                            Console.WriteLine("Номер должен содержать только цифры!");
                                            break;
                                        }

                                        var books = _bookService.GetBooksByAuthorId(number);
                                        if (books.Count == 0)
                                        {
                                            Console.WriteLine("Книги данного автора не были найдены.");
                                            break;
                                        }

                                        foreach (var b in books)
                                        {
                                            Console.WriteLine(b.ToString());
                                        }

                                        break;
                                    }
                                default:
                                    Console.WriteLine("Вы выбрали некорректный пункт меню!");
                                    break;
                            }
                            break;
                        }
                    case "4":
                        {
                            ReaderModel reader;
                            try
                            {
                                reader = getReaderByNumber();
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                                break;
                            }
                            if (reader == null)
                            {
                                Console.WriteLine($"Данный клиент не был найден");
                                break;
                            }
                            string subSelector;
                            Console.Write("[1] - Показать книги, которые сейчас находятся у читателя\n" +
                                     "[2] - Показать возвращенные книги\n" +
                                     "Введите ваш выбор: ");
                            subSelector = Console.ReadLine();
                            switch (subSelector)
                            {
                                case "1":
                                    {
                                        var books = reader.GetCurrentlyBorrowedBooks();
                                        if(books.Count == 0)
                                        {
                                            Console.WriteLine("Книги не были найдены.");
                                            break;
                                        }
                                        foreach (var b in books)
                                        {
                                            Console.WriteLine(b.ToString());
                                        }
                                        break;
                                    }
                                case "2":
                                    {
                                        var books = reader.GetReturnedBooks();
                                        if (books.Count == 0)
                                        {
                                            Console.WriteLine("Книги не были найдены.");
                                            break;
                                        }
                                        foreach (var b in books)
                                        {
                                            Console.WriteLine(b.ToString());
                                        }
                                        break;
                                    }
                                default:
                                    Console.WriteLine("Вы выбрали некорректный пункт меню!");
                                    break;
                            }
                            break;
                        }
                    default:
                        Console.WriteLine("Вы выбрали некорректный пункт меню!");
                        break;
                }
            } while (true);
        }

        private ReaderModel getReaderByNumber()
        {
            Console.Write("Введите номер: ");
            string numberStr = Console.ReadLine();

            if (!int.TryParse(numberStr, out int number))
            {
                throw new FormatException("Номер должен содержать только цифры!");
            }
            return _readerService.GetReaderByTicketNumber(number);
        }

    }
}
