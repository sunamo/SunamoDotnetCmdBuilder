namespace SunamoDotnetCmdBuilder;

public class Sln(StringBuilder stringBuilder)
{
    public void RemoveProject(string slnFile, string projectPath)
    {
        stringBuilder.AppendLine($"dotnet sln {slnFile} remove {projectPath}");
    }

    // slnPath can be empty when running in a folder where there is only one sln file.
    public void AddProject(string slnPath, string csprojRelativePath)
    {
        stringBuilder.AppendLine($"dotnet sln {slnPath} add {csprojRelativePath}");
    }
}
