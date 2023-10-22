using FluentValidation;
using Proje.Domain.AppEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.RemoveByIdMainRoleAndRoleRL
{
    public sealed class RemoveByIdMainRoleAndRoleRLCommandValidator: AbstractValidator<RemoveByIdMainRoleAndRoleRLCommand>
    {
        public RemoveByIdMainRoleAndRoleRLCommandValidator()
        {
            RuleFor(p => p.id).NotEmpty().WithMessage("Id alanı zorunludur");
            RuleFor(p => p.id).NotNull().WithMessage("Id alanı zorunludur");
        }
    }
}
