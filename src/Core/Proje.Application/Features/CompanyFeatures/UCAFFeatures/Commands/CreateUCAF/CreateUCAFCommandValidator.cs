using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF
{
    public sealed class CreateUCAFCommandValidator : AbstractValidator<CreateUCAFCommand>
    {
        public CreateUCAFCommandValidator()
        {
            RuleFor(p => p.Code).NotEmpty().WithMessage("Code boş olamaz");
            RuleFor(p => p.Code).NotNull().WithMessage("Code boş olamaz");
            RuleFor(p => p.Code).MinimumLength(4).WithMessage("Code enaz 4 karakter olmalıdır");
            RuleFor(p => p.Name).NotEmpty().WithMessage("Adı boş olamaz");
            RuleFor(p => p.Name).NotNull().WithMessage("Adı boş olamaz");

            RuleFor(p => p.CompanyId).NotEmpty().WithMessage("Şirket Id boş olamaz");
            RuleFor(p => p.CompanyId).NotNull().WithMessage("Şirket Id boş olamaz");

            RuleFor(p => p.Type).NotEmpty().WithMessage("Tipi boş olamaz");
            RuleFor(p => p.Type).NotNull().WithMessage("Tipi boş olamaz");
            RuleFor(p => p.Type).MustAsync(BeAValidLength).WithMessage("Tipi 1 karakter olmalı.");

        }

        private async Task<bool> BeAValidLength(char arg1, CancellationToken token)
        {
            var value = false;
            if (arg1.ToString().Length == 1)
            {
                value = true;
            }
            return value;
        }
    }
}
