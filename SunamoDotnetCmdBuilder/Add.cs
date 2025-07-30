namespace SunamoDotnetCmdBuilder;

public class Add(StringBuilder sb)
{
    public void AddPackage(string projectPathOrName, string packageName)
    {
        sb.AppendLine($"dotnet add {projectPathOrName} package {packageName}");
    }
}