namespace NovaHR.Contracts.Authentication;

public record LogonRequest(
    string FirstName,
    string LastName,
    string Email,
    string Password
);

