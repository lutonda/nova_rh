namespace NovaHR.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Login(string Email, string Password);

    AuthenticationResult Logon(string FirstName, string LastName, string Email, string Password);
}