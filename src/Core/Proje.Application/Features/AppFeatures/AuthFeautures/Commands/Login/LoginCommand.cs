using Proje.Application.Messaging;

namespace Proje.Application.Features.AppFeatures.AuthFeautures.Commands.Login
{
    public sealed record LoginCommand(string EmailOrUsername, string Password) : ICommand<LoginCommandResponse>;
}
