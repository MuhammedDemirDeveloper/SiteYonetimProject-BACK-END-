using FluentValidation;
using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class PersonellerValidator:AbstractValidator<Personeller>

    {
        public PersonellerValidator()
        {
            RuleFor(x => x.PersonelAdi).MinimumLength(2).MaximumLength(15).NotEmpty().WithMessage("Min(2),Max(15) Karakter Olmalıdır.Boş Bırakmayınız");
            RuleFor(x => x.PersonelSoyadi).MinimumLength(2).MaximumLength(15).NotEmpty().WithMessage("Min(2),Max(15) Karakter Olmalıdır.Boş Bırakmayınız");
            RuleFor(x => x.PersonelDurum).MaximumLength(50).NotEmpty().WithMessage("Max(50) Karakter Olmalıdır.Personel Durum Alanını Boş Bırakmayınız.");
            RuleFor(x => x.PersonelTc).NotEmpty().WithMessage("TC Kimlik No Alanı Boş Bırakmayınız");
            RuleFor(x => x.PersonelTel).NotEmpty().WithMessage("Personel Tel Alanı Boş Bırakmayınız"); 


           

        }
    }
}
