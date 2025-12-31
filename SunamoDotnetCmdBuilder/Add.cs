namespace SunamoDotnetCmdBuilder;

public class Add(StringBuilder stringBuilder)
{
    public void AddPackage(string projectPathOrName, string packageName)
    {
        stringBuilder.AppendLine($"dotnet add {projectPathOrName} package {packageName}");
    }
}