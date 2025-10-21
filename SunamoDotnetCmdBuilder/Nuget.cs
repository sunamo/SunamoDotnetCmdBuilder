// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoDotnetCmdBuilder;

public class Nuget(StringBuilder sb)
{
    public void Push(string args)
    {
        sb.AppendLine("dotnet nuget push " + args);
    }
}