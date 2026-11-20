namespace SunamoDotnetCmdBuilder;

/// <summary>
/// Represents the dotnet cmd builder type.
/// </summary>
public class DotnetCmdBuilder
{
    private readonly StringBuilder stringBuilder = new();

    /// <summary>
    /// Gets or sets the sln.
    /// </summary>
    public Sln Sln { get; set; }

    /// <summary>
    /// Gets or sets the add.
    /// </summary>
    public Add Add { get; set; }

    /// <summary>
    /// Gets or sets the nuget.
    /// </summary>
    public Nuget Nuget { get; set; }

    /// <summary>
    /// Dotnet cmd builder.
    /// </summary>
    /// <returns>The dotnet cmd builder result.</returns>
    public DotnetCmdBuilder()
    {
        Sln = new Sln(stringBuilder);
        Add = new Add(stringBuilder);
        Nuget = new Nuget(stringBuilder);
    }

    /// <summary>
    /// Cd.
    /// </summary>
    /// <returns>The cd result.</returns>
    public void Cd(string path)
    {
        stringBuilder.AppendLine($"cd {path}");
    }

    /// <summary>
    /// Clean.
    /// </summary>
    /// <param name="stringBuilder">The string builder.</param>
    /// <returns>The clean result.</returns>
    public void Clean()
    {
        Prefix("clean");
    }

    /// <summary>
    /// Pack.
    /// </summary>
    /// <param name="{path}"">The path.</param>
    /// <returns>The pack result.</returns>
    public void Pack()
    {
        Prefix("pack");
    }

    private void Prefix(string command)
    {
        stringBuilder.AppendLine($"dotnet {command}");
    }

    /// <summary>
    /// Build.
    /// </summary>
    /// <param name=""pack"">The pack.</param>
    /// <returns>The build result.</returns>
    public void Build(string arguments)
    {
        stringBuilder.AppendLine($"dotnet build {arguments}");
    }

    /// <summary>
    /// To string.
    /// </summary>
    /// <param name="{command}"">The command.</param>
    /// <returns>The to string result.</returns>
    public override string ToString()
    {
        return stringBuilder.ToString();
    }
}
