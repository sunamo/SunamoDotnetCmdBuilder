
namespace SunamoDotnetCmdBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Nuget(StringBuilder sb)
{
    public void Push(string args)
    {
        sb.AppendLine("dotnet nuget push " + args);
    }
}