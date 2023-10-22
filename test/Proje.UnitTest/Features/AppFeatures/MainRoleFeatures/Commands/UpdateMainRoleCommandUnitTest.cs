using Moq;
using Proje.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using Proje.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole;
using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.UnitTest.Features.AppFeatures.MainRoleFeatures.Commands
{
    public sealed class UpdateMainRoleCommandUnitTest
    {
        private readonly Mock<IMainRoleService> _mainRoleService;

        public UpdateMainRoleCommandUnitTest()
        {
            _mainRoleService = new();
        }

        [Fact]
        public async Task MainRoleShouldNotBeNull()
        {
            _mainRoleService.Setup(x=>x.GetByIdAsync(It.IsAny<string>()))
                .ReturnsAsync(new MainRole());
            
        }

        [Fact]
        public async Task CreateMainRoleCommandResponseShouldNotBeNull()
        {
            var command = new UpdateMainRoleCommand(
                Title: "Admin",
                Id: "187A79EB-CB9F-4096-9FEC-0BA927CE35F4"
                );

            var handler = new UpdateMainRoleCommandHandler(_mainRoleService.Object);

            _mainRoleService.Setup(x => x.GetByIdAsync(It.IsAny<string>()))
               .ReturnsAsync(new MainRole());

            UpdateMainRoleCommandResponse response = await handler.Handle(command, default);

            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();

        }
    }
}
