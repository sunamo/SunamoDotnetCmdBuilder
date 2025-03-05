namespace SunamoDotnetCmdBuilder;

public class Nuget(StringBuilder sb)
{
    public void Push(string args)
    {
        sb.AppendLine("dotnet nuget push " + args);
    }
}