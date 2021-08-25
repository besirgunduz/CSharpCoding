using BookStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        List<Book> BookList = new List<Book>()
        {
            new Book{Id=1,GenreId=1,PageCount=100,Title="Kitap1",PublishDate=new DateTime(2021,08,25)},
            new Book{Id=2,GenreId=1,PageCount=100,Title="Kitap2",PublishDate=new DateTime(2021,08,25)},
            new Book{Id=3,GenreId=1,PageCount=100,Title="Kitap3",PublishDate=new DateTime(2021,08,25)}

        };

        [HttpGet("GetBooks")]
        public List<Book> GetBooks()
        {
            var bookList = BookList.OrderBy(b => b.Id).ToList<Book>();
            return bookList;
        }

        [HttpGet("GetById")]
        public Book GetById(int id)
        {
            var book = BookList.Where(b => b.Id == id).SingleOrDefault();
            return book;
        }
    }
}
