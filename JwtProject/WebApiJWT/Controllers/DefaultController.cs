using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiJWT.Models;

namespace WebApiJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult Test() //Test Token Oluşturma
        {
            return Ok(new Token().TokenCreate());
        }

        [HttpGet("[action]")]
        public IActionResult AdminTokenCreate() 
        {
            return Ok(new Token().AdminToken());
        }

        [Authorize]
        [HttpGet("[action]")]
        public IActionResult AuthorizeControl()
        {
            return Ok("Hoşgeldiniz");
        }

        [Authorize(Roles ="Admin,Visitor")]
        [HttpGet("[action]")]
        public IActionResult AuthorizeControlByRole()
        {
            return Ok("Kullanıcı başarılı bir şekilde giriş yaptı.");
        }
    }
}
