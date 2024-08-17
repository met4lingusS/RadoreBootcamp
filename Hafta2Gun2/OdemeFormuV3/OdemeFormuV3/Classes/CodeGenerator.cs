using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormuV3.Classes
{
    public static class CodeGenerator
    {
        public static string GenerateClassCode(string className, List<string> propertyNames)
        {
            var sb = new StringBuilder();

            sb.AppendLine("using System;");
            sb.AppendLine();
            sb.AppendLine($"public class {className}");
            sb.AppendLine("{");

            foreach (var propertyName in propertyNames)
            {
                sb.AppendLine($"    public string {propertyName} {{ get; set; }}");
            }

            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}
