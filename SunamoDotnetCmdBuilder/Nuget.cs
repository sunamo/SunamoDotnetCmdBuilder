namespace SunamoDotnetCmdBuilder;

public class Nuget(StringBuilder stringBuilder)
{
    public void Push(string args)
    {
        stringBuilder.AppendLine("dotnet nuget push " + args);
    }
}