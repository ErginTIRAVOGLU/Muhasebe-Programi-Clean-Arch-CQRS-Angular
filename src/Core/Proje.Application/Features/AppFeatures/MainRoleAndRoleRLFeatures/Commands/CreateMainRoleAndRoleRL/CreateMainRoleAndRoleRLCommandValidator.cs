using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL
{
    public sealed class CreateMainRoleAndRoleRLCommandValidator:AbstractValidator<CreateMainRoleAndRoleRLCommand>
    {
        public CreateMainRoleAndRoleRLCommandValidator()
        {
            RuleFor(p=>p.RoleId).NotEmpty().WithMessage("Role seçilmelidir");
            RuleFor(p => p.RoleId).NotNull().WithMessage("Role seçilmelidir");
            RuleFor(p => p.MainRoleId).NotEmpty().WithMessage("Ana Role seçilmelidir");
            RuleFor(p => p.MainRoleId).NotNull().WithMessage("Ana Role seçilmelidir");
        }
    }
}
