using Library.DAL.Abstract.IRepositories;
using Library.DAL.Abstract.IUnitOfWork;
using Library.DAL.EF;
using Library.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Dependencies
{
    public static class DependenciesConfiguration
    {
        public static IServiceCollection RegisterDependencies(this IServiceCollection services)
        {
            services.AddScoped<LibraryDbContext, LibraryDbContext>();

            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookAuthorRepository, BookAuthorRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IGenreBookRepository, GenreBookRepository>();
            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<IReaderRepository, ReaderRepository>();
            services.AddScoped<IRecordRepository, RecordRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();

            return services;
        }
    }
}
