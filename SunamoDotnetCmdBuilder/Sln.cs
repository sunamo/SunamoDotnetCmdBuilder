namespace SunamoDotnetCmdBuilder;

/// <summary>
/// Provides methods for generating dotnet sln commands.
/// </summary>
/// <param name="stringBuilder">The StringBuilder to append commands to.</param>
public class Sln(StringBuilder stringBuilder)
{
    /// <summary>
    /// Generates a dotnet sln remove command to remove a project from a solution.
    /// </summary>
    /// <param name="slnFile">The path to the solution file.</param>
    /// <param name="projectPath">The path to the project to remove.</param>
    public void RemoveProject(string slnFile, string projectPath)
    {
        stringBuilder.AppendLine($"dotnet sln {slnFile} remove {projectPath}");
    }

    /// <summary>
    /// Generates a dotnet sln add command to add a project to a solution.
    /// The slnPath can be empty when running in a folder where there is only one sln file.
    /// </summary>
    /// <param name="slnPath">The path to the solution file, or empty string to use the default sln in the current directory.</param>
    /// <param name="csprojRelativePath">The relative path to the csproj file to add.</param>
    public void AddProject(string slnPath, string csprojRelativePath)
    {
        stringBuilder.AppendLine($"dotnet sln {slnPath} add {csprojRelativePath}");
    }
}