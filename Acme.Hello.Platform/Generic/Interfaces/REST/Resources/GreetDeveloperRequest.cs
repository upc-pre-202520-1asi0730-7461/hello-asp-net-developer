namespace Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

/// <summary>
/// Request to greet a developer
/// </summary>
/// <remarks>
/// This request is used to greet a developer by their first and last name.
/// The names are optional and can be null.
/// </remarks>
/// <param name="FirstName">The first name of the developer</param>
/// <param name="LastName">The last name of the developer</param>
public record GreetDeveloperRequest(string? FirstName, string? LastName);