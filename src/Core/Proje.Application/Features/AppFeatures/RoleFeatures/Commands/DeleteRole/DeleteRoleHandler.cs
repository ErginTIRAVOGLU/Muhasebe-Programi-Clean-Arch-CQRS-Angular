﻿using MediatR;
using Proje.Application.Services.AppServices;
using Proje.Domain.AppEntities.Identity;

namespace Proje.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole
{
    public sealed class DeleteRoleHandler : IRequestHandler<DeleteRoleRequest, DeleteRoleResponse>
    {
        private readonly IRoleService _roleService;

        public DeleteRoleHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<DeleteRoleResponse> Handle(DeleteRoleRequest request, CancellationToken cancellationToken)
        {
            AppRole role = await _roleService.GetById(request.Id);
            if (role == null) { throw new Exception("Role bulunamadı."); }
           
            await _roleService.DeleteAsync(role);   
            return new ();
            
        }
    }
}