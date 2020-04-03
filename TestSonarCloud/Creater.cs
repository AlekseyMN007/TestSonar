using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSonarCloud
{
    public class Creater
    {
        public static string CreateName()
        {
            string[] mass = new string[5] { "dfg", "dfg", "dfg", "dfg", "dfg" };

            // Random random = new Random();
            string result = mass.ElementAt((new Random()).Next(0, mass.Length));

            return "Your sign is: "+result;
        }
    }
}
