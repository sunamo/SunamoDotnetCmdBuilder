namespace SunamoDotnetCmdBuilder;

public class DotnetCmdBuilder
{
    private readonly StringBuilder stringBuilder = new();
    public Sln Sln { get; set; } = null;
    public Add Add { get; set; } = null;
    public Nuget Nuget { get; set; } = null;

    public DotnetCmdBuilder()
    {
        Sln = new Sln(stringBuilder);
        Add = new Add(stringBuilder);
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

    private void Prefix(string v)
    {
        stringBuilder.AppendLine("dotnet " + v);
    }

    public void Build(string args)
    {
        stringBuilder.AppendLine("dotnet build " + args);
    }

    public override string ToString()
    {
        return stringBuilder.ToString();
    }
}