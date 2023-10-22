using Proje.Domain.AppEntities;

namespace Proje.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Queries
{
    public sealed record GetAllMainRoleAndRoleRLQueryResponse(
        List<MainRoleAndRoleRelationship> mainRoleAndRoleRelationships);
}