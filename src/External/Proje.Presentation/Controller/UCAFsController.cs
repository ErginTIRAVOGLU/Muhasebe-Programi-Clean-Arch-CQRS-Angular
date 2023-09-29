﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Proje.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using Proje.Presentation.Abstraction;

namespace Proje.Presentation.Controller
{
    public sealed class UCAFsController : ApiController
    {
        public UCAFsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateUCAF(CreateUCAFRequest request)
        {
            CreateUCAFResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}