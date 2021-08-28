using AutoMapper;
using BookStore.Dtos;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<GetBooksDto, Book>();
            CreateMap<Book, GetBooksDto>();

            CreateMap<GetByIdDto, Book>();
            CreateMap<Book, GetByIdDto>();

            CreateMap<AddBookDto, Book>();
            CreateMap<Book, AddBookDto>();




        }
    }
}
