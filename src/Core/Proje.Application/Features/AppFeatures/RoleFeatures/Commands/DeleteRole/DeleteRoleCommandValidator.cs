using FluentValidation;

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
