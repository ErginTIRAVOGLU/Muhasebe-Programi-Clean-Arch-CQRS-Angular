using MediatR;
using Proje.Application.Messaging;
using System.Windows.Input;

namespace Proje.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole
{
    public sealed record CreateRoleCommand(
        string Name, 
        string Code) : ICommand<CreateRoleCommandResponse>;
}
