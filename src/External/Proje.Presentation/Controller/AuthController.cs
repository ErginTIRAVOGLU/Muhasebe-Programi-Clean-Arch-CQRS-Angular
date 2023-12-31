﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Proje.Application.Features.AppFeatures.AuthFeautures.Commands.Login;
using Proje.Application.Features.AppFeatures.AuthFeautures.Queries.GetRolesByUserIdAndCompanyId;
using Proje.Presentation.Abstraction;

namespace Proje.Presentation.Controller
{
    public class AuthController : ApiController
    {
        public AuthController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginCommand request)
        {
            LoginCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> GetRolesByUserIdAndCompanyId(GetRolesByUserIdAndCompanyIdQuery request)
        {
            GetRolesByUserIdAndCompanyIdQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
