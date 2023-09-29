using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany
{
    public sealed class CreateCompanyCommandValidator : AbstractValidator<CreateCompanyCommand>
    {
        public CreateCompanyCommandValidator()
        {
            RuleFor(p => p.DatabaseName).NotEmpty().WithMessage("Database boş bırakılamaz");
            RuleFor(p => p.DatabaseName).NotNull().WithMessage("Database boş bırakılamaz");

            RuleFor(p => p.ServerName).NotEmpty().WithMessage("ServerName boş bırakılamaz");
            RuleFor(p => p.ServerName).NotNull().WithMessage("ServerName boş bırakılamaz");

            RuleFor(p => p.Name).NotEmpty().WithMessage("Şirket Adı boş bırakılamaz");
            RuleFor(p => p.Name).NotNull().WithMessage("Şirket Adı boş bırakılamaz");

        }
    }
}
