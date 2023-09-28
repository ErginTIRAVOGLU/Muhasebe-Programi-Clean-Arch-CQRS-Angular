using AutoMapper;
using Proje.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using Proje.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using Proje.Domain.AppEntities;
using Proje.Domain.CompanyEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Persistance.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCompanyRequest, Company>().ReverseMap();
            CreateMap<CreateUCAFRequest, UniformCartOfAccount>().ReverseMap();
        }
    }
}
