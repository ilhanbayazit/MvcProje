using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class HeadingValidator : AbstractValidator<Heading>
    {
        public HeadingValidator()
        {
            RuleFor(x => x.HeadingName).NotEmpty().WithMessage("Başlık ismi boş geçilemez");
            //RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori açıklaması boş geçilemez");
            RuleFor(x => x.HeadingName).MinimumLength(3).WithMessage("Başlık ismi en az 3 karakterden oluşmalı");
            RuleFor(x => x.HeadingName).MaximumLength(20).WithMessage("Başlık ismi 20 karakterden fazla olamaz");

        }
    }
}
