using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.UserAndCompanyRLFeatures.Commands.CreateUserAndCompanyRL
{
    public sealed class CreateUserAndCompanyRLCommandValidation : AbstractValidator<CreateUserAndCompanyRLCommand>
    {
        public CreateUserAndCompanyRLCommandValidation()
        {
            RuleFor(p => p.AppUserId).NotEmpty().WithMessage("Kullanıcı seçilmelidir");
            RuleFor(p => p.AppUserId).NotNull().WithMessage("Kullanıcı seçilmelidir");
            RuleFor(p => p.CompanyId).NotEmpty().WithMessage("Kullanıcı seçilmelidir");
            RuleFor(p => p.CompanyId).NotNull().WithMessage("Kullanıcı seçilmelidir");
        }
    }
}
