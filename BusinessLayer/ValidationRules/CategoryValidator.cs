﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklama alanını boş geçemezsiniz.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen en az 3 karakterlik kategori adı girişi yapınız.");
            RuleFor(x => x.CategoryName).MaximumLength(25).WithMessage("Lütfen en fazla 25 karakterlik kategori adı girişi yapınız.");

        }
    }
}
