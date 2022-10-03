using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public static string parseStatement(string statement)
        {
            int a = int.Parse(statement.Substring(0, 1));
            int b = int.Parse(statement.Substring(2, 1));
            // string operation = statement.Substring(1, 1);
            int result = a + b;
            return result.ToString();
        }
    }
}
