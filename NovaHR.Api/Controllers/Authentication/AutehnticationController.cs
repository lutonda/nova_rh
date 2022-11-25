using Microsoft.AspNetCore.Mvc;
using NovaHR.Contracts.Authentication;
namespace NovaHR.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase{

        [Route("login")]
        public IActionResult Login(LoginRequest request){
           return Ok(request); 
        }

        [Route("logon")]
        public IActionResult Logon(LogonRequest request){
           return Ok(request); 
        }

}