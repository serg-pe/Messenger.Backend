using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.WebApi.Controllers
{
    [Authorize]
    [Route("api/secret")]
    public class SecretController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetSecretHello() => "Hello, Secret World!";
    }
}