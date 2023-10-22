using Moq;
using Proje.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL;
using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.UnitTest.Features.AppFeatures.MainRoleAndRoleRLFeatures
{
    public class CreateMainRoleAndRoleRLCommandUnitTest
    {
        private readonly Mock<IMainRoleAndRoleRelationshipService> _service;

        public CreateMainRoleAndRoleRLCommandUnitTest()
        {
            _service = new();
        }

        [Fact]
        public async Task MainRoleAndRoleRelationshipShoulBeNull()
        {
            MainRoleAndRoleRelationship entity = await _service.Object.GetByRoleIdAndMainRoleId(
                roleId: "58027EEC-BD47-4C75-9A3C-DBB74048BC1D",
                mainRoleId: "D25F1733-99F1-4ED4-A73E-5ADEF0E3F6E5",
                cancellationToken: default);
            entity.ShouldBeNull();
        }

        [Fact]
        public async Task CreateMainRoleAndRoleRLCommandResponseShouldNotBeNull()
        {
            var command = new CreateMainRoleAndRoleRLCommand(
                RoleId: "58027EEC-BD47-4C75-9A3C-DBB74048BC1D",
                MainRoleId: "D25F1733-99F1-4ED4-A73E-5ADEF0E3F6E5");

            var handler = new CreateMainRoleAndRoleRLCommandHandler(_service.Object);

            CreateMainRoleAndRoleRLCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
