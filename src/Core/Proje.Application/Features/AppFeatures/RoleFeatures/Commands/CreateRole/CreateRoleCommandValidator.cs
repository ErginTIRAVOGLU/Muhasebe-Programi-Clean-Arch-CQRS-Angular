using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole
{
    public sealed class CreateRoleCommandValidator:AbstractValidator<CreateRoleCommand>
    {
        public CreateRoleCommandValidator()
        {
            RuleFor(p => p.Code).NotEmpty().WithMessage("Role Code boş olamaz");
            RuleFor(p => p.Code).NotNull().WithMessage("Role Code boş olamaz");

            RuleFor(p => p.Name).NotEmpty().WithMessage("Role Name boş olamaz");
            RuleFor(p => p.Name).NotNull().WithMessage("Role Name boş olamaz");
        }
    }
}
