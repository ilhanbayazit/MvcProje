using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {

            RuleFor(x => x.ReciverMail).NotEmpty().WithMessage("Alıcı ismi boş geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Mesaj konusu boş geçilemez");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaj boş geçilemez");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Mesaj konusu en az 3 karakterden oluşmalı");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Mesaj konusunu 100 karakterden fazla girmeyin");
            //RuleFor(x => x.ReciverMail)
            //    .NotEmpty().WithMessage("Alıcı mail boş geçilemez")
            //    .EmailAddress().WithMessage("Geçerli bir mail adresi giriniz")
            //    .Must(MailAdresiKayitliMi).WithMessage("Bu mail adresi sistemde kayıtlı değil");

        }
        //private bool MailAdresiKayitliMi(string mail)
        //{
        //    if (string.IsNullOrWhiteSpace(mail))
        //        return false;

        //    using (Context c = new Context())
        //    {
        //        return c.Contacts.Any(x => x.UserMail == mail);
        //    }
        //}

    }
}
