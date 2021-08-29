using BookStore.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.FluentValidation
{
    public class GetByIdDtoValidator: AbstractValidator<GetByIdDto>
    {
        public GetByIdDtoValidator()
        {
            RuleFor(b => b.Id).GreaterThan(0);
        }
    }
}
