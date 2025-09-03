namespace Acme.Hello.Platform.Generic.Domain.Model.Entities;

/// <summary>
/// Represents a developer entity with a first and last name.
/// </summary>
/// <remarks>
/// This class is immutable and provides methods to retrieve the full name
/// </remarks>
public class Developer
{
    public Guid Id { get;  } = Guid.NewGuid();
    
    public string FirstName { get; }
    
    public string LastName { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Developer"/> class.
    /// In case of null or whitespace, the names are set to empty strings.
    /// </summary>
    /// <param name="firstName">The first name of the developer.</param>
    /// <param name="lastName">The last name of the developer.</param>
    public Developer(string firstName, string lastName)
    {
        FirstName = string.IsNullOrWhiteSpace(firstName) ? "" : firstName.Trim();
        LastName = string.IsNullOrWhiteSpace(lastName) ? "" : lastName.Trim();
    }
    
    /// <summary>
    /// Gets the full name of the developer by concatenating the first and last names.
    /// </summary>
    /// <returns>A string with the format "FirstName LastName".</returns>
    public string GetFullName() => $"{FirstName} {LastName}".Trim();
    
    /// <summary>
    /// Checks if either the first name or last name is empty.
    /// </summary>
    /// <returns>True if either name is empty; otherwise, false.</returns>
    public bool IsAnyNameEmpty() => 
        string.IsNullOrEmpty(FirstName) 
        || string.IsNullOrEmpty(LastName);
}