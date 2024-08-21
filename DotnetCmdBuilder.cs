
namespace SunamoDotnetCmdBuilder;
public class DotnetCmdBuilder
{
    private readonly StringBuilder sb = new();
    public Sln Sln { get; set; } = null;
    public Add Add { get; set; } = null;
    public Nuget Nuget { get; set; } = null;

    public DotnetCmdBuilder()
    {
        Sln = new Sln(sb);
        Add = new Add(sb);
    }

    public void Cd(string path)
    {
        sb.AppendLine("cd " + path);
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
        sb.AppendLine("dotnet " + v);
    }

    public void Build(string args)
    {
        sb.AppendLine("dotnet build " + args);
    }

    public override string ToString()
    {
        return sb.ToString();
    }
}