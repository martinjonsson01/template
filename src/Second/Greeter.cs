namespace Second;

/// <summary>
/// Greets the caller.
/// </summary>
public class Greeter
{
    /// <summary>
    /// Greet the given user.
    /// </summary>
    /// <param name="name">The name of the user.</param>
    /// <returns>The greeting in text format.</returns>
    public string Greet(string? name = null)
    {
        return name is null ? "Hello there!" : $"Hello, {name}!";
    }
}
