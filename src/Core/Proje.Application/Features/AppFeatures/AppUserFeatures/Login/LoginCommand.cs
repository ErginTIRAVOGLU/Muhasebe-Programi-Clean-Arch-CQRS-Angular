using MediatR;
using Proje.Application.Messaging;
using System.Windows.Input;

namespace Proje.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public sealed record LoginCommand(string EmailOrUsername, string Password):ICommand<LoginCommandResponse>;
}
