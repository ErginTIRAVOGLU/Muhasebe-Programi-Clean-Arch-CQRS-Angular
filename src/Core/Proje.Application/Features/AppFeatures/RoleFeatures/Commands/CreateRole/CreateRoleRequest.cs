using MediatR;

namespace Proje.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole
{
    public sealed class CreateRoleRequest : IRequest<CreateRoleResponse>
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
