using BookStore.Dtos;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.DBOperations
{
    public interface IAppRepository
    {
        void Add<T>(T entity);
        void Update<T>(T entity);
        void Delete<T>(T entity);
        bool SaveAll();
        List<Book> GetBooks();
        Book GetById(int id);
    }
}
