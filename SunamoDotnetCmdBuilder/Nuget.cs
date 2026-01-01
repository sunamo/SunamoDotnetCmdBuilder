namespace SunamoDotnetCmdBuilder;

/// <summary>
/// Provides methods for generating dotnet nuget commands.
/// </summary>
/// <param name="stringBuilder">The StringBuilder to append commands to.</param>
public class Nuget(StringBuilder stringBuilder)
{
    /// <summary>
    /// Generates a dotnet nuget push command to publish a package.
    /// </summary>
    /// <param name="arguments">The arguments to pass to the push command (e.g., package path, source, API key).</param>
    public void Push(string arguments)
    {
        stringBuilder.AppendLine("dotnet nuget push " + arguments);
    }
}
