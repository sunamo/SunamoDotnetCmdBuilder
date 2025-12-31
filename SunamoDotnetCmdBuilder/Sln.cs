namespace SunamoDotnetCmdBuilder;

public class Sln(StringBuilder stringBuilder)
{
    public void Remove(string slnFile, string projectPath)
    {
        stringBuilder.AppendLine($"dotnet sln {slnFile} remove {projectPath}");
    }
    /// <summary>
    /// slnPath can be "" when running in folder where is only one sln
    /// </summary>
    /// <param name="slnPath"></param>
    /// <param name="csprojRelativePath"></param>
    public void AddProject(string slnPath, string csprojRelativePath)
    {
        stringBuilder.AppendLine($"dotnet sln {slnPath} add {csprojRelativePath}");
    }
}