using BookStore.DBOperations;
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
        IAppRepository _appRepository;
        public BooksController(IAppRepository appRepository)
        {
            _appRepository = appRepository;
        }

        [HttpGet("GetBooks")]
        public List<Book> GetBooks()
        {
            var bookList = _appRepository.GetBooks();
            return bookList;
        }

        [HttpGet("GetById")]
        public Book GetById(int id)
        {
            var book = _appRepository.GetById(id);
            return book;
        }

        [HttpPost("AddBook")]
        public IActionResult AddBook([FromBody] Book newBook)
        {
            _appRepository.Add(newBook);
            _appRepository.SaveAll();
            return Ok();
        }

        [HttpPut("UpdateBook")]
        public IActionResult UpdateBook(int id)
        {
            var book = _appRepository.GetById(id);
            book.Name = "Olasılıksız";
            _appRepository.Update(book);
            _appRepository.SaveAll();
            return Ok();

        }

        [HttpDelete("DeleteBook")]
        public IActionResult DeleteBook(int id)
        {
            var book = _appRepository.GetById(id);
            _appRepository.Delete(book);
            _appRepository.SaveAll();
            return Ok();
        }
    }
}
