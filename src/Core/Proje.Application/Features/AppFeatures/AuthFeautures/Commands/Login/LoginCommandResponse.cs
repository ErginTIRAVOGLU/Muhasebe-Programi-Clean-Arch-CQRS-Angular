using Proje.Domain.AppEntities;
using Proje.Domain.Dtos;

namespace Proje.Application.Features.AppFeatures.AuthFeautures.Commands.Login
{
    public sealed record LoginCommandResponse(
        TokenRefreshTokenDto Token,
        string Email,
        string UserId,
        string Name,
        string Surname,
        IList<CompanyDto> Companies,
        CompanyDto Company,
        int Year
        );
}