
namespace SunamoDotnetCmdBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Sln(StringBuilder sb)
{
    public void Remove(string slnFile, string projectPath)
    {
        sb.AppendLine($"dotnet sln {slnFile} remove {projectPath}");
    }

    /// <summary>
    /// slnPath can be "" when running in folder where is only one sln
    /// </summary>
    /// <param name="slnPath"></param>
    /// <param name="csprojRelativePath"></param>
    public void AddProject(string slnPath, string csprojRelativePath)
    {
        sb.AppendLine($"dotnet sln {slnPath} add {csprojRelativePath}");
    }
}