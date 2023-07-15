using FluentValidation;
using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class KisilerValidator:AbstractValidator<Kisiler>
    {
        public KisilerValidator()
        {
            RuleFor(x => x.Adi).MinimumLength(2).MaximumLength(15).NotEmpty().WithMessage("Min(2),Max(15) Karakter Olmalıdır.Boş Bırakmayınız"); 
            RuleFor(x=>x.Soyadi).MinimumLength(2).MaximumLength(15).NotEmpty().WithMessage("Min(2),Max(15) Karakter Olmalıdır.Boş Bırakmayınız");
            RuleFor(x => x.TcKimlikNo).NotEmpty().WithMessage("TC.Kimlik No Alanını Boş Bırakmayınız");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen E-mail Adresinizi Kontrol Ediniz.");
            RuleFor(x => x.Durum).MaximumLength(10).NotEmpty().WithMessage("Max(10) Karakter Olmalıdır.Kisi Durum Alanını Boş Bırakmayınız");
            RuleFor(x => x.TelNo1).NotEmpty().WithMessage("Tel No 1 Alanımı Boş Bırakmayınız");
            RuleFor(x => x.TelNo2).NotEmpty().WithMessage("Tel No 2 Alanını Boş Bırakmayınız"); 



        }
    }
}
