using Moq;
using Proje.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.CreateMainRoleAndUserRL;
using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.UnitTest.Features.AppFeatures.MainRoleAndUserRLFeatures
{
    public sealed class CreateMainRoleAndUserRLCommandUnitTest
    {
        private readonly Mock<IMainRoleAndUserRelationshipService> _serviceMock;

        public CreateMainRoleAndUserRLCommandUnitTest()
        {
            _serviceMock = new();
        }

        [Fact]
        public async Task MainRoleAndUserRelationshipShouldBeNull()
        {
            MainRoleAndUserRelationship entity = await _serviceMock.Object
                .GetByUserIdCompanyIdAndMainRoleIdAsync(
                userId: "F56CD898-29E4-41F6-BF1B-CADC7EA09589",
                companyId: "0988D593-2383-473F-8CFF-B3246A2FE7F9",
                mainRoleId: "2D0DAE3E-288C-45CC-8B7C-D36DCB2A3F9A",
                cancellationToken: default);
            entity.ShouldBeNull();
        }
        [Fact]
        public async Task CreateMainRoleAndUserRLCommandResponseShouldNotBeNull()
        {
            CreateMainRoleAndUserRLCommand command = new (
                UserId: "F56CD898-29E4-41F6-BF1B-CADC7EA09589",
                CompanyId: "0988D593-2383-473F-8CFF-B3246A2FE7F9",
                MainRoleId: "2D0DAE3E-288C-45CC-8B7C-D36DCB2A3F9A");
            CreateMainRoleAndUserRLCommandHandler handler=new(_serviceMock.Object);
            CreateMainRoleAndUserRLCommandResponse response = await handler.Handle(command, default);

            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();

        }
    }
}
