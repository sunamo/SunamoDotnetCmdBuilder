namespace SunamoDotnetCmdBuilder;

/// <summary>
/// Nuget.
/// </summary>
/// <param name="stringBuilder">The string builder.</param>
/// <returns>The nuget result.</returns>
public class Nuget(StringBuilder stringBuilder)
{
    /// <summary>
    /// Push.
    /// </summary>
    /// <param name="arguments">The arguments.</param>
    public void Push(string arguments)
    {
        stringBuilder.AppendLine($"dotnet nuget push {arguments}");
    }
}
