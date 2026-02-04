namespace SunamoDotnetCmdBuilder;

/// <summary>
/// Provides methods for generating dotnet add commands.
/// </summary>
/// <param name="stringBuilder">The StringBuilder to append commands to.</param>
public class Add(StringBuilder stringBuilder)
{
    /// <summary>
    /// Generates a dotnet add package command.
    /// </summary>
    /// <param name="projectPathOrName">The project path or name to add the package to.</param>
    /// <param name="packageName">The name of the NuGet package to add.</param>
    public void AddPackage(string projectPathOrName, string packageName)
    {
        stringBuilder.AppendLine($"dotnet add {projectPathOrName} package {packageName}");
    }
}