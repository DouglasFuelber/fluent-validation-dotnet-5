using FluentValidation.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidation.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult ActionName(User user)
        {
            return Ok();
        }
    }
}