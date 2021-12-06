using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Collections;

namespace Linq_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Linq concept in C# .

            /// <summary>
            /// Linq to Sql;
            /// Linq to XML;
            /// Linq to Object;
            /// Linq to Dataset;
            /// Linq to Entity;
            /// </summary>

            ///
            /// Query Syntax 
            /// Non-Quuery Syntax
            ///

            /// Compare queries 

            List <string> Names = new List <string>()
            {
                "khalil","bouhousse","home","speed","window","get","Slow","Server"
            };

            List <string> Result = new List <string>();

            for (int i = 0; i < Names.Count ; i++)
            {
                if (Names[i].Length > 3)
                {
                    Result.Add(Names[i]); // Only Items that Greater than 3 Characters . & Index start from 0 .
                }
            }

            foreach (var result in Result)
            {
                Console.WriteLine($"the Result is {result}");
            }
        }
    }
}
