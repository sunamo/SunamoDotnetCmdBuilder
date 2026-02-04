namespace SunamoDotnetCmdBuilder;

/// <summary>
/// Provides a fluent API for building dotnet CLI commands.
/// </summary>
public class DotnetCmdBuilder
{
    private readonly StringBuilder stringBuilder = new();

    /// <summary>
    /// Gets or sets the Sln command builder.
    /// </summary>
    public Sln Sln { get; set; }

    /// <summary>
    /// Gets or sets the Add command builder.
    /// </summary>
    public Add Add { get; set; }

    /// <summary>
    /// Gets or sets the Nuget command builder.
    /// </summary>
    public Nuget Nuget { get; set; }

    /// <summary>
    /// Initializes a new instance of the DotnetCmdBuilder class.
    /// </summary>
    public DotnetCmdBuilder()
    {
        Sln = new Sln(stringBuilder);
        Add = new Add(stringBuilder);
        Nuget = new Nuget(stringBuilder);
    }

    /// <summary>
    /// Adds a cd (change directory) command.
    /// </summary>
    /// <param name="path">The path to change to.</param>
    public void Cd(string path)
    {
        stringBuilder.AppendLine("cd " + path);
    }

    /// <summary>
    /// Adds a dotnet clean command.
    /// </summary>
    public void Clean()
    {
        Prefix("clean");
    }

    /// <summary>
    /// Adds a dotnet pack command.
    /// </summary>
    public void Pack()
    {
        Prefix("pack");
    }

    /// <summary>
    /// Adds a dotnet command with the specified command name.
    /// </summary>
    /// <param name="command">The command name to append after "dotnet ".</param>
    private void Prefix(string command)
    {
        stringBuilder.AppendLine("dotnet " + command);
    }

    /// <summary>
    /// Adds a dotnet build command with optional arguments.
    /// </summary>
    /// <param name="arguments">The arguments to pass to the build command.</param>
    public void Build(string arguments)
    {
        stringBuilder.AppendLine("dotnet build " + arguments);
    }

    /// <summary>
    /// Returns the accumulated command string.
    /// </summary>
    /// <returns>A string containing all the accumulated dotnet commands.</returns>
    public override string ToString()
    {
        return stringBuilder.ToString();
    }
}