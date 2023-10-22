using Moq;
using Proje.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.UnitTest.Features.AppFeatures.MainFeatures.Commands
{
    public sealed class CreateMainRoleCommandUnitTest
    {
        private readonly Mock<IMainRoleService> _mainRoleService;

        public CreateMainRoleCommandUnitTest()
        {
            _mainRoleService = new();
        }

        [Fact]
        public async Task MainRoleShouldBeNull()
        {
            MainRole mainRole = await _mainRoleService.Object.GetByTitleAndCompanyId(
                title: "Admin",
                companyId: "187A79EB-CB9F-4096-9FEC-0BA927CE35F4",
                default);
            mainRole.ShouldBeNull();
        }

        [Fact]
        public async Task CreateMainRoleCommandResponseShouldNotBeNull()
        {
            var command = new CreateMainRoleCommand(
                Title: "Admin",
                CompanyId: "187A79EB-CB9F-4096-9FEC-0BA927CE35F4"
                );

            var handler = new CreateMainRoleCommandHandler(_mainRoleService.Object);

            CreateMainRoleCommandResponse response = await handler.Handle(command, default);

            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();

        }
    }
}
