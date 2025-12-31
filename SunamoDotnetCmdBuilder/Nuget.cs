namespace SunamoDotnetCmdBuilder;

public class Nuget(StringBuilder stringBuilder)
{
    public void Push(string arguments)
    {
        stringBuilder.AppendLine("dotnet nuget push " + arguments);
    }
}