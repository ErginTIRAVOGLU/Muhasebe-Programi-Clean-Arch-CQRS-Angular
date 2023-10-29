﻿using Proje.Application.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.RemoveByIdMainRoleAndUserRL
{
    public sealed record RemoveByIdMainRoleAndUserRLCommand( string Id):ICommand<RemoveByIdMainRoleAndUserRLCommandResponse>;
}
