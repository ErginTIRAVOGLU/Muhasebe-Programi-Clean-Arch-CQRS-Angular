using Moq;
using Proje.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole;
using Proje.Application.Services.AppServices;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.UnitTest.Features.AppFeatures.MainRoleFeatures.Commands
{
    public sealed class RemoveByIdMainRoleCommandUnitTest
    {
        private readonly Mock<IMainRoleService> _mainRoleService;

        public RemoveByIdMainRoleCommandUnitTest()
        {
            _mainRoleService = new();
        }

        [Fact]
        public async Task RemoveByIdMainRoleCommandResponseShouldNotBeNull()
        {
            var command = new RemoveByIdMainRoleCommand(                 
                Id: "187A79EB-CB9F-4096-9FEC-0BA927CE35F4"
                );

            var handler = new RemoveByIdMainRoleCommandHandler(_mainRoleService.Object);

            RemoveByIdMainRoleCommandResponse response = await handler.Handle(command, default);

            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();

        }
    }
}
