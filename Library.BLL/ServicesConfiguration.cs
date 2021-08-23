using Library.BLL.Mappers;
using Library.BLL.Mappers.Abstract;
using Library.BLL.Services;
using Library.BLL.Services.Abstract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection RegisterServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IAuthorService, AuthorService>();
            serviceCollection.AddScoped<IAuthorMapper, AuthorMapper>();
            serviceCollection.AddScoped<IBookService, BookService>();
            serviceCollection.AddScoped<IBookMapper, BookMapper>();
            serviceCollection.AddScoped<IReaderService, ReaderService>();
            serviceCollection.AddScoped<IReaderMapper, ReaderMapper>();
            serviceCollection.AddScoped<IGenreService, GenreService>();
            serviceCollection.AddScoped<IGenreMapper, GenreMapper>();
            serviceCollection.AddScoped<IRecordService, RecordService>();
            serviceCollection.AddScoped<IRecordMapper, RecordMapper>();
            return serviceCollection;
        }
    }
}
