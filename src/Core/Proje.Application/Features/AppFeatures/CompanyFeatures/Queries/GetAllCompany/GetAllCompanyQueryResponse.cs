using Proje.Domain.AppEntities;

namespace Proje.Application.Features.AppFeatures.CompanyFeatures.Queries.GetAllCompany
{
    public sealed record GetAllCompanyQueryResponse(List<Company> Companies);
}