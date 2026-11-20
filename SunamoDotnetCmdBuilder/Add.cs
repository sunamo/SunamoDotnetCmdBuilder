namespace SunamoDotnetCmdBuilder;

/// <summary>
/// Add.
/// </summary>
/// <param name="stringBuilder">The string builder.</param>
/// <returns>The add result.</returns>
public class Add(StringBuilder stringBuilder)
{
    /// <summary>
    /// Add package.
    /// </summary>
    /// <param name="projectPathOrName">The project path or name.</param>
    /// <param name="packageName">The package name.</param>
    public void AddPackage(string projectPathOrName, string packageName)
    {
        stringBuilder.AppendLine($"dotnet add {projectPathOrName} package {packageName}");
    }
}