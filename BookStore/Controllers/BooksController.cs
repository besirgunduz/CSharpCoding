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
        private static List<Book> BookList = new List<Book>()
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

        [HttpPost("AddBook")]
        public IActionResult AddBook([FromBody] Book newBook)
        {
            var book = BookList.SingleOrDefault(b => b.Id == newBook.Id);

            if (book != null)
                return BadRequest();

            BookList.Add(newBook);
            return Ok();
        }

        [HttpPut("UpdateBook")]
        public IActionResult UpdateBook([FromBody] Book newBook, int id)
        {
            var book = BookList.Where(b => b.Id == id).SingleOrDefault();

            if (book == null)
                return BadRequest();

            book.GenreId = newBook.GenreId != default ? newBook.GenreId : book.GenreId;
            book.Title = newBook.Title != default ? newBook.Title : book.Title;

            return Ok();

        }

        [HttpDelete("DeleteBook")]
        public IActionResult DeleteBook(int id)
        {
            var book = BookList.SingleOrDefault(b => b.Id == id);

            if (book == null)
                return BadRequest();

            BookList.Remove(book);

            return Ok();
        }
    }
}
