using Microsoft.AspNetCore.Mvc;
using NovaHR.Contracts.Authentication;
using NovaHR.Application.Services.Authentication;
namespace NovaHR.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase{

        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService){
            _authenticationService = authenticationService;
        }
        [Route("login")]
        public IActionResult Login(LoginRequest request){

            var login=_authenticationService.Login(request.Email, request.Password);
           return Ok(login); 
        }

        [Route("logon")]
        public IActionResult Logon(LogonRequest request){
            var logon=_authenticationService.Logon(request.FirstName, request.LastName, request.Email, request.Password);
           return Ok(logon); 
        }

}