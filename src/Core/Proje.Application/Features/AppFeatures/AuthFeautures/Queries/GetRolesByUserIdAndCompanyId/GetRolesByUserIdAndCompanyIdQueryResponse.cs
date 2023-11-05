namespace Proje.Application.Features.AppFeatures.AuthFeautures.Queries.GetRolesByUserIdAndCompanyId
{
    public sealed record GetRolesByUserIdAndCompanyIdQueryResponse(
        IList<string> Roles);
}