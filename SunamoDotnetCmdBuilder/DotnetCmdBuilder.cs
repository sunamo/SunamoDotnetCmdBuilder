namespace SunamoDotnetCmdBuilder;

public class DotnetCmdBuilder
{
    private readonly StringBuilder stringBuilder = new();
    public Sln Sln { get; set; }
    public Add Add { get; set; }
    public Nuget Nuget { get; set; }

    public DotnetCmdBuilder()
    {
        Sln = new Sln(stringBuilder);
        Add = new Add(stringBuilder);
        Nuget = new Nuget(stringBuilder);
    }

    public void Cd(string path)
    {
        stringBuilder.AppendLine("cd " + path);
    }

    public void Clean()
    {
        Prefix("clean");
    }

    public void Pack()
    {
        Prefix("pack");
    }

    private void Prefix(string command)
    {
        stringBuilder.AppendLine("dotnet " + command);
    }

    public void Build(string arguments)
    {
        stringBuilder.AppendLine("dotnet build " + arguments);
    }

    public override string ToString()
    {
        return stringBuilder.ToString();
    }
}