using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x=>x.WriterName).NotEmpty().WithMessage("Yazar Adı soyadı boş geçilemez");
            RuleFor(x => x.WriterEmail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(p => p.WriterEmail).Matches(@"[@,.]+").WithMessage("Mail adresi @ ve . icermelidir");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Sifre bos gecilemez");
            RuleFor(p => p.WriterPassword).Matches(@"[A-Z]+").WithMessage("Sifrede en az bir büyük harf olmalıdır.");
            RuleFor(p => p.WriterPassword).Matches(@"[a-z]+").WithMessage("Sifrede en az bir küçük harf olmalıdır.");
            RuleFor(x => x.ConfirmPassword).Equal(x => x.WriterPassword).WithMessage("Parolalar Eşleşmiyor.");
            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız.");
        }
    }
}
