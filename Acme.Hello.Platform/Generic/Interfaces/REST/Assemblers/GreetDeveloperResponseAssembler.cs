using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

namespace Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;

/// <summary>
/// Assembler for Developer entity.
/// </summary>
public static class GreetDeveloperResponseAssembler
{
    /// <summary>
    /// Converts a Developer entity to a GreetDeveloperResponse.
    /// </summary>
    /// <remarks>
    /// If the entity is null or has any empty name, it returns a default response for an anonymous developer.
    /// Otherwise, it constructs a response with the developer's ID, full name, and a congratulatory message.
    /// </remarks>
    /// <param name="entity">The <see cref="Developer"/> entity to convert.</param>
    /// <returns>The corresponding <see cref="GreetDeveloperResponse"/>.</returns>
    public static GreetDeveloperResponse ToResponseFromEntity(Developer? entity)
    {
        if (entity == null || entity.IsAnyNameEmpty())
            return new GreetDeveloperResponse("Welcome Anonymous ASP.NET Developer");
        return new GreetDeveloperResponse(entity.Id, entity.GetFullName(),
            $"Congrats {entity.GetFullName()}! You are an ASP.NET Developer");
    }
    
}