using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole
{
    public sealed class DeleteRoleCommandValidator:AbstractValidator<DeleteRoleCommand>
    {
        public DeleteRoleCommandValidator()
        {
            RuleFor(p => p.Id).NotEmpty().WithMessage("Id boş olamaz");
            RuleFor(p => p.Id).NotNull().WithMessage("Id boş olamaz");

        }
    }
}
