using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Adresi boş geçilemez");
            RuleFor(x => x.UserSubject).NotEmpty().WithMessage("Konu Adı boş geçilemez");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı boş geçilemez");
            RuleFor(x => x.UserSubject).MinimumLength(3).WithMessage("Konu Adı en az 3 karakterden oluşmalı");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Kullanıcı Adı 3 karakterden az olamaz");

        }
    }
}
