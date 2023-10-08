using Proje.Application.Messaging;

namespace Proje.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole
{
    public sealed record CreateRoleCommand(
        string Name, 
        string Code) : ICommand<CreateRoleCommandResponse>;
}
