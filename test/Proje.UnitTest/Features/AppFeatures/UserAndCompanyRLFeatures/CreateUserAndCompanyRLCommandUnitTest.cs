using Moq;
using Proje.Application.Features.AppFeatures.UserAndCompanyRLFeatures.Commands.CreateUserAndCompanyRL;
using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities;
using Proje.Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.UnitTest.Features.AppFeatures.UserAndCompanyRLFeatures
{
    public sealed class CreateUserAndCompanyRLCommandUnitTest
    {
        private readonly Mock<IUserAndCompanyRelationshipService> _serviceMock;

        public CreateUserAndCompanyRLCommandUnitTest()
        {
            _serviceMock = new();
        }

        [Fact]
        public async Task UserAndCompanyRelationshipShouldBeNull()
        {
            UserAndCompanyRelationship userAndCompanyRelationship = await
                _serviceMock.Object.GetByUserIdAndCompanyId(
                    userId: "9215347B-55EB-4CB3-A1C9-51A46C43D67C",
                    companyId: "5EF68B3C-CADA-4488-A774-93D841D3D41D", 
                    cancellationToken: default);
            userAndCompanyRelationship.ShouldBeNull();
        }

        [Fact]
        public async Task CreateUserAndCompanyRLCommandResponseShouldNotBeNull()
        {
            CreateUserAndCompanyRLCommand command = new(
                AppUserId: "9215347B-55EB-4CB3-A1C9-51A46C43D67C",
                CompanyId: "5EF68B3C-CADA-4488-A774-93D841D3D41D");

            CreateUserAndCompanyRLCommandHandler handler = new(_serviceMock.Object);
            CreateUserAndCompanyRLCommandResponse response=await handler.Handle(command,default);
            response.ShouldNotBeNull();
        }
    }
}
