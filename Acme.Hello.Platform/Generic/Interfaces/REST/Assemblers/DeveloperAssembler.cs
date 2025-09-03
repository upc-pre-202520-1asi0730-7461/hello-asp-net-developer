using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

namespace Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;

/// <summary>
/// Assembler for Developer entity.
/// </summary>
public static class DeveloperAssembler
{
    /// <summary>
    /// Converts a GreetDeveloperRequest to a Developer entity.
    /// </summary>
    /// <param name="request">The <see cref="GreetDeveloperRequest"/> to convert.</param>
    /// <returns>The corresponding <see cref="Developer"/> entity, or null if the request is invalid.</returns>
    public static Developer? ToEntityFromRequest(GreetDeveloperRequest? request)
    {
        if (request == null
            || string.IsNullOrWhiteSpace(request.FirstName)
            || string.IsNullOrWhiteSpace(request.LastName))
        {
            return null;
        }
        return new Developer(request.FirstName, request.LastName);
    }
}