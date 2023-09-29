using AutoMapper;
using Proje.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using Proje.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using Proje.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using Proje.Domain.AppEntities;
using Proje.Domain.AppEntities.Identity;
using Proje.Domain.CompanyEntities;

namespace Proje.Persistance.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCompanyCommand, Company>().ReverseMap();
            CreateMap<CreateUCAFCommand, UniformCartOfAccount>().ReverseMap();

            CreateMap<CreateRoleCommand,AppRole>().ReverseMap();
        }
    }
}
