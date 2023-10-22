using Moq;
using Proje.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.RemoveByIdMainRoleAndRoleRL;
using Proje.Application.Services.AppServices;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.UnitTest.Features.AppFeatures.MainRoleAndRoleRLFeatures
{
    public sealed class RemoveByIdMainRoleAndRoleRLCommandUnitTest
    {
        private readonly Mock<IMainRoleAndRoleRelationshipService> _serviceMock;

        public RemoveByIdMainRoleAndRoleRLCommandUnitTest()
        {
            _serviceMock = new();
        }

        [Fact]
        public async Task MainRoleAndRoleRelationshipShouldNotBeNull()
        {
            _serviceMock.Setup(s=>
            s.GetByIdAsync(It.IsAny<string>()))
                .ReturnsAsync(new Domain.AppEntities.MainRoleAndRoleRelationship());
        }

        [Fact]
        public async Task RemoveByIdMainRoleAndRoleRLCommandResponseShouldNotBeNull()
        {
            RemoveByIdMainRoleAndRoleRLCommand removeByIdMainRoleAndRoleRLCommand = new(id:"00754E00-1EDE-472A-9329-C4026C5E6899");
            RemoveByIdMainRoleAndRoleRLCommandHandler handler = new RemoveByIdMainRoleAndRoleRLCommandHandler(_serviceMock.Object);

            _serviceMock.Setup(s =>
           s.GetByIdAsync(It.IsAny<string>()))
               .ReturnsAsync(new Domain.AppEntities.MainRoleAndRoleRelationship());

            var response = await handler.Handle(removeByIdMainRoleAndRoleRLCommand, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
