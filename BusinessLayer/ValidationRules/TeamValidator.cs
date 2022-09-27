using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Takım arkadaşı imini boş  geçemezsiniz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev  kısmı boş geçilemez");
            RuleFor(x=>x.ImageUrl).NotEmpty().WithMessage("Resim yolu  kısmı boş geçilemez");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla isim girmeyiniz");
            RuleFor(x => x.PersonName).MaximumLength(5).WithMessage("Lütfen 5 karakterden az isim girmeyiniz");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen 50 karakterden az Veri Girin");
            RuleFor(x => x.Title).MaximumLength(5).WithMessage("Lütfen 5 karakterden az Veri girmeyiniz");
        }
    }
}
