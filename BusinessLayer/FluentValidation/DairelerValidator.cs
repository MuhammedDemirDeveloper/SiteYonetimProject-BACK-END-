using FluentValidation;
using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class DairelerValidator:AbstractValidator<Daireler>
    {
        public DairelerValidator()
        {
            RuleFor(x => x.DaireTanim).MinimumLength(2).MaximumLength(5).NotEmpty().WithMessage("Min.(2),Max(5) Karakter olmalıdır. Boş bırakmayınız.");
            RuleFor(x => x.DaireOdaSayisi).NotEmpty().WithMessage("Daire oda sayısını yazınız");

        }
    }
}
