﻿using Proje.Domain.AppEntities;

namespace Proje.Application.Features.AppFeatures.MainRoleFeatures.Queries.GetAllMainRole
{
    public sealed record GetAllMainRoleQueryResponse(IList<MainRole> MainRoles);
    
}