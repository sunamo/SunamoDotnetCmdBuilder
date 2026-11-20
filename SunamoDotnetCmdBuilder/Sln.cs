namespace SunamoDotnetCmdBuilder;

/// <summary>
/// Sln.
/// </summary>
/// <param name="stringBuilder">The string builder.</param>
/// <returns>The sln result.</returns>
public class Sln(StringBuilder stringBuilder)
{
    /// <summary>
    /// Remove project.
    /// </summary>
    /// <param name="slnFile">The sln file.</param>
    /// <param name="projectPath">The project path.</param>
    public void RemoveProject(string slnFile, string projectPath)
    {
        stringBuilder.AppendLine($"dotnet sln {slnFile} remove {projectPath}");
    }

    // slnPath can be empty when running in a folder where there is only one sln file.
    /// <summary>
    /// Add project.
    /// </summary>
    /// <param name="slnPath">The sln path.</param>
    /// <param name="csprojRelativePath">The csproj relative path.</param>
    public void AddProject(string slnPath, string csprojRelativePath)
    {
        stringBuilder.AppendLine($"dotnet sln {slnPath} add {csprojRelativePath}");
    }
}
