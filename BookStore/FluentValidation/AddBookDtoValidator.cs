using BookStore.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.FluentValidation
{
    public class AddBookDtoValidator:AbstractValidator<AddBookDto>
    {
        public AddBookDtoValidator()
        {
            RuleFor(b => b.Name).NotEmpty().MinimumLength(4);
        }
    }
}
