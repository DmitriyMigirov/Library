using Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.EF
{
    class LibraryDbInitializer : DropCreateDatabaseAlways<LibraryDbContext>
    {
        protected override void Seed(LibraryDbContext context)
        {
            base.Seed(context);

            var genreNovel = context.Genres.Add(new Genre()
            {
                Name = "novel"
            });

            var genreFiction = context.Genres.Add(new Genre()
            {
                Name = "fiction"
            });

            var genreComedy = context.Genres.Add(new Genre()
            {
                Name = "comedy"
            });

            var genreScienceFiction = context.Genres.Add(new Genre()
            {
                Name = "science fiction"
            });

            var genreSocicalFiction = context.Genres.Add(new Genre()
            {
                Name = "social fiction"
            });

            var genreMilitaryNovel = context.Genres.Add(new Genre()
            {
                Name = "military novel"
            });

            var genreBlackHumor = context.Genres.Add(new Genre()
            {
                Name = "black humor"
            });


            context.SaveChanges();

            var authorDavid = context.Authors.Add(new Author()
            {
                Name = "Дэвид",
                Surname = "Джером",
                Parentname = "Сэлинджер"
            });

            var authorJohn = context.Authors.Add(new Author()
            {
                Name = "Джон",
                Surname = "Руэл",
                Parentname = "Толкин"
            });

            var authorJane = context.Authors.Add(new Author()
            {
                Name = "Джейн",
                Surname = "Остин",
                Parentname = ""
            });

            var authorAdams = context.Authors.Add(new Author()
            {
                Name = "Адамс",
                Surname = "Дуглас",
                Parentname = "Ноэль"
            });

            var authorJoanne = context.Authors.Add(new Author()
            {
                Name = "Джоан",
                Surname = "Роулинг",
                Parentname = "Кэтлин"
            });

            var authorNelle = context.Authors.Add(new Author()
            {
                Name = "Нелл",
                Surname = "Харпер",
                Parentname = "Лі"
            });

            var authorOrwell = context.Authors.Add(new Author()
            {
                Name = "Джордж",
                Surname = "Оруэлл",
                Parentname = "Блэр"
            });

            var authorSebastian = context.Authors.Add(new Author()
            {
                Name = "Себастьян",
                Surname = "Чарльз",
                Parentname = "Фолкс"
            });

            var authorJoseph = context.Authors.Add(new Author()
            {
                Name = "Джосеф",
                Surname = "Хеллер",
                Parentname = ""
            });

            var authorEmily = context.Authors.Add(new Author()
            {
                Name = "Эмили",
                Surname = "Джейн",
                Parentname = "Бронте"
            });



            context.SaveChanges();

            var book1 = context.Books.Add(new Book()
            {
                Title = "Над пропастью во ржи",
                Number = 3432,
                IsBorrowed = false,
                PageCount = 213,
                ReleaseDate = new DateTime(1951, 1, 1)
            });

            book1.Authors.Add(authorDavid);
            book1.Genres.Add(genreNovel);

            var book2 = context.Books.Add(new Book()
            {
                Title = "Властелин колец",
                Number = 5389,
                IsBorrowed = true,
                PageCount = 200,
                ReleaseDate = new DateTime(1955, 4, 20)
            });

            book2.Authors.Add(authorJohn);
            book2.Genres.Add(genreFiction);

            var book3 = context.Books.Add(new Book()
            {
                Title = "Гордость и предубеждение",
                Number = 4893,
                IsBorrowed = false,
                PageCount = 241,
                ReleaseDate = new DateTime(1796, 1, 1)
            });

            book3.Genres.Add(genreNovel);
            book3.Authors.Add(authorJane);

            var book4 = context.Books.Add(new Book()
            {
                Title = "Автостопом по галактике",
                Number = 1231,
                IsBorrowed = false,
                PageCount = 310,
                ReleaseDate = new DateTime(1979, 04, 12)
            });

            book4.Authors.Add(authorAdams);
            book4.Genres.Add(genreScienceFiction);
            book4.Genres.Add(genreComedy);

            var book5 = context.Books.Add(new Book()
            {
                Title = "Гарри Поттер и Кубок огня",
                Number = 9929,
                IsBorrowed = false,
                PageCount = 489,
                ReleaseDate = new DateTime(2000, 6, 8)
            });

            book5.Authors.Add(authorJoanne);
            book5.Genres.Add(genreNovel);

            var book6 = context.Books.Add(new Book()
            {
                Title = "Убить пересмешника",
                Number = 4312,
                IsBorrowed = false,
                PageCount = 421,
                ReleaseDate = new DateTime(1796, 1, 1)
            });

            book6.Authors.Add(authorNelle);
            book6.Genres.Add(genreNovel);

            var book7 = context.Books.Add(new Book()
            {
                Title = "1984",
                Number = 5318,
                IsBorrowed = false,
                PageCount = 137,
                ReleaseDate = new DateTime(1796, 1, 1)
            });

            book7.Genres.Add(genreSocicalFiction);
            book7.Authors.Add(authorOrwell);

            var book8 = context.Books.Add(new Book()
            {
                Title = "Пение птиц",
                Number = 9640,
                IsBorrowed = false,
                PageCount = 192,
                ReleaseDate = new DateTime(1979, 5, 7)
            });

            book8.Authors.Add(authorSebastian);
            book8.Genres.Add(genreNovel);

            var book9 = context.Books.Add(new Book()
            {
                Title = "Уловка-22",
                Number = 1125,
                IsBorrowed = false,
                PageCount = 188,
                ReleaseDate = new DateTime(1796, 1, 1)
            });

            book9.Authors.Add(authorJoseph);
            book9.Genres.Add(genreBlackHumor);
            book9.Genres.Add(genreMilitaryNovel);

            var book10 = context.Books.Add(new Book()
            {
                Title = "Грозовой перевал",
                Number = 9311,
                IsBorrowed = false,
                PageCount = 270,
                ReleaseDate = new DateTime(1796, 1, 1)
            });

            book10.Genres.Add(genreNovel);
            book10.Authors.Add(authorEmily);

            context.SaveChanges();
            var reader = context.Readers.Add(new Reader()
            {
                Name = "Боб",
                Surname = "Левицки",
                Parentname = "Шевич",
                Passport = "0019312",
                Phone = "+9 309 123 323",
                TicketNumber = 493014
            });

            context.SaveChanges();

            var record = context.Records.Add(new Record()
            {
                BorrowDate = DateTime.Now.Subtract(new TimeSpan(3, 5, 20)),
                Reader = reader,
                Book = book2,
                ReturnDate = null
            });

            context.SaveChanges();

            record.Reader = reader;

            context.SaveChanges();

            reader.Records.Add(record);

            context.SaveChanges();
        }
    }
}
