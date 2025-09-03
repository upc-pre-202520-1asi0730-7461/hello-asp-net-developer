namespace Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

/// <summary>
/// Response to greet a developer
/// </summary>
/// <remarks>
/// This response is used to return the result of greeting a developer.
/// It contains the ID and FullName of the developer if provided, otherwise they are null.
/// It also contains a Message with the greeting.
/// </remarks>
/// <param name="Id">The ID of the developer</param>
/// <param name="FullName">The full name of the developer</param>
/// <param name="Message">The greeting message</param>
public record GreetDeveloperResponse(Guid? Id, string? FullName, string Message)
{
    /// <summary>
    /// Constructor for GreetDeveloperResponse with only message
    /// </summary>
    /// <remarks>
    /// This constructor is used when only the greeting message is available.
    /// It internally calls the primary constructor with null values for ID and FullName.
    /// </remarks>
    /// <param name="message">The greeting message</param>
    public GreetDeveloperResponse(string message) : this(null, null, message) { }
}