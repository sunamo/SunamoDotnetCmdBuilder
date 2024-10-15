namespace SunamoDotnetCmdBuilder;
using System.Text;

public class Add(StringBuilder sb)
{
    public void AddPackage(string projectPathOrName, string packageName)
    {
        sb.AppendLine($"dotnet add {projectPathOrName} package {packageName}");
    }
}