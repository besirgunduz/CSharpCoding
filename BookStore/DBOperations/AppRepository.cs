using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.DBOperations
{
    public class AppRepository : IAppRepository
    {

        BookStoreDbContext _context;
        public AppRepository(BookStoreDbContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }

        public List<Book> GetBooks()
        {
            var books = _context.Books.ToList();
            return books;
        }

        public Book GetById(int id)
        {
            var book = _context.Books.Where(b => b.Id == id).SingleOrDefault();
            return book;
        }
    }
}
