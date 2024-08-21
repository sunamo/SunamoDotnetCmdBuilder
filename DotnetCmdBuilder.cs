
namespace SunamoDotnetCmdBuilder;
public class DotnetCmdBuilder
{
    private readonly StringBuilder sb = new();
    Sln sln { get; set; } = null;
    Add add { get; set; } = null;

    public DotnetCmdBuilder()
    {
        sln = new Sln(sb);
        add = new Add(sb);
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