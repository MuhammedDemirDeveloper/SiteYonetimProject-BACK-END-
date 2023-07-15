using FluentValidation;
using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class BloklarValidator : AbstractValidator<Bloklar>


    {
        public BloklarValidator()
        {
            RuleFor(x => x.BlokTanim).NotEmpty().WithMessage("Blok bilgisi boş geçilemez.");
            RuleFor(x => x.BlokTanim).MinimumLength(2).WithMessage("Minimum 2 karakter olmalıdır.");
            RuleFor(x => x.BlokTanim).MaximumLength(5).WithMessage("Blok Tanımı 5 karakteri geçmemelidir.");
            RuleFor(x => x.BlokDaireSayisi).NotEmpty().WithMessage("Lütfen daire sayısını giriniz.");
            
        }

    }
}
