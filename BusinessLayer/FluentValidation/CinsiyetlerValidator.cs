using FluentValidation;
using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CinsiyetlerValidator:AbstractValidator<Cinsiyetler>
    {
        public CinsiyetlerValidator()
        {
            RuleFor(x => x.Cinsiyet).NotEmpty().WithMessage("Lütfen cinsiyet alanını boş bırakmayınız.");
            RuleFor(x => x.Cinsiyet).MaximumLength(6).WithMessage("Cinsiyet tanımı geçersiz!.");



        }
    }
}
