using Proje.Application.Messaging;

namespace Proje.Application.Features.AppFeatures.AppUserFeatures.Commands.Login
{
    public sealed record LoginCommand(string EmailOrUsername, string Password) : ICommand<LoginCommandResponse>;
}
