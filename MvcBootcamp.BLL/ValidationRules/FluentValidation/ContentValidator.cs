﻿using FluentValidation;
using MvcBootcamp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBootcamp.BLL.ValidationRules.FluentValidation
{
    public class ContentValidator:AbstractValidator<Content>
    {
        public ContentValidator()
        {
            RuleFor(x => x.Text).NotEmpty().WithMessage("İçerik giriniz.");
            RuleFor(x => x.Text).MaximumLength(5000).WithMessage("İçerik için max. 5000 karakter içermelidir.");
        }
    }
}
