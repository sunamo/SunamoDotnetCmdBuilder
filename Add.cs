
namespace SunamoDotnetCmdBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Add(StringBuilder sb)
{
    public void AddPackage(string projectPathOrName, string packageName)
    {
        sb.AppendLine($"dotnet add {projectPathOrName} package {packageName}");
    }
}