using AutoMapper;
using BookStore.DBOperations;
using BookStore.Dtos;
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
        IMapper _mapper;
        public BooksController(IAppRepository appRepository, IMapper mapper)
        {
            _appRepository = appRepository;
            _mapper = mapper;
        }

        [HttpGet("GetBooks")]
        public IActionResult GetBooks()
        {
            var bookList = _appRepository.GetBooks();
            var bookListToReturn = _mapper.Map<List<GetBooksDto>>(bookList);
            return Ok(bookListToReturn);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var book = _appRepository.GetById(id);
            var bookToReturn = _mapper.Map<GetByIdDto>(book);
            return Ok(bookToReturn);
        }

        [HttpPost("AddBook")]
        public IActionResult AddBook([FromBody] AddBookDto newBook)
        {
            var bookToReturn = _mapper.Map<Book>(newBook);
            _appRepository.Add(bookToReturn);
            _appRepository.SaveAll();
            return Ok();
        }

        [HttpPut("UpdateBook")]
        public IActionResult UpdateBook([FromBody] UpdateBookDto updateBook, int id)
        {
            var book = _appRepository.GetById(id);

            book.Name = updateBook.Name;
            book.Price = updateBook.Price;

            var bookToReturn = _mapper.Map<Book>(book);

            _appRepository.Update(bookToReturn);
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
