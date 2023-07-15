using FluentValidation;
using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class FirmalarValidator:AbstractValidator<Firmalar>
    {
        public FirmalarValidator()
        {
            RuleFor(x => x.FirmaAdi).MinimumLength(3).MaximumLength(30).NotEmpty().WithMessage("Min.(3),Max(30) Karakter olmalıdır.Boş Bırakmayınız.");
            RuleFor(x => x.FirmaTelNo).NotEmpty().WithMessage("Firma Tel boş bırakılmamalıdır.");
            RuleFor(x => x.FirmaEmail).EmailAddress().NotEmpty().WithMessage("Lütfen E-mail adresinizi kontrol ediniz.Boş bırakmayınız.");
            RuleFor(x => x.FirmaSifre).NotEmpty().WithMessage("LÜtfen şifre alanını boş bırakmayınız");
            RuleFor(x => x.FirmaAdres).MinimumLength(10).MaximumLength(100).NotEmpty().WithMessage("Min(10),Max(100) Karakter olmalıdır.Boş bırakmayınız");
            RuleFor(x => x.FirmaKayitTarihi).NotEmpty().WithMessage("Lütfen boş bırakmayınız."); 

        }
    }
}
