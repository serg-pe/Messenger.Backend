using Messenger.Application.Common.Interfaces;
using Messenger.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Messenger.WebApi.Controllers
{
    [AllowAnonymous]
    [Route("api/hello")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly IChatsRepository _chatsRepository;
        private readonly IDateTime _dateTimeService;

        public HelloController(IChatsRepository chatsRepository, IDateTime dataTimeService)
        {
            _chatsRepository = chatsRepository;
            _dateTimeService = dataTimeService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public string GetHelloString() => "Hello, World";
    }
}
