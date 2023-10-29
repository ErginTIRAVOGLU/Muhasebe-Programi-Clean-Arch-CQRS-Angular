using Moq;
using Proje.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.RemoveByIdMainRoleAndUserRL;
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
    public sealed class RemoveByIdMainRoleAndUserRLCommandUnitTest
    {
        private readonly Mock<IMainRoleAndUserRelationshipService> _serviceMock;

        public RemoveByIdMainRoleAndUserRLCommandUnitTest()
        {
            _serviceMock = new();
        }

        [Fact]
        public async Task RemoveByIdMainRoleAndUserRelationshipShoultNotBeNull()
        {
            _serviceMock.Setup(
                x => x.GetByIdAsync(It.IsAny<string>(), false))
                .ReturnsAsync(new MainRoleAndUserRelationship()); 
        }

        [Fact]
        public async Task RemoveByIdMainRoleAndUserRLCommandResponseShouldNotBeNull()
        {
            RemoveByIdMainRoleAndUserRLCommand command = new(Id: "");

            RemoveByIdMainRoleAndUserRLCommandHandler handler=new(_serviceMock.Object);

            _serviceMock.Setup(
               x => x.GetByIdAsync(It.IsAny<string>(), false))
               .ReturnsAsync(new MainRoleAndUserRelationship());
        
        RemoveByIdMainRoleAndUserRLCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
