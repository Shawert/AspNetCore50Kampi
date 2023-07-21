using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterVlidator : AbstractValidator<Writer>
    {

        public WriterVlidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı Boş olmaz");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi Boş olamaz");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre adresi Boş olamaz");
            RuleFor(p => p.WriterPassword).Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.");
            RuleFor(p => p.WriterPassword).Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.");
            RuleFor(p => p.WriterPassword).Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.");
            RuleFor(x => x.WriterPassword).Matches(@"[\!\?\*\.]*$").WithMessage("Your password must contain at least one (!? *.).");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen En Az 2 karakterli giriniz");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Gerçerli Bir İsim Giriniz(2-50)");
        }

    }
}
