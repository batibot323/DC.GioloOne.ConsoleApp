using System;
using System.Collections.Generic;
using System.Text;

namespace DC.GioloOne.ConsoleApp
{
    public class Solution
    {
        public string Solve(string input)
        {
            string output = "";
            output += input.Substring(0, 1);
            output += input.Substring(2, 1);
            output += " ";
            output += input.Substring(1, 1);
            output += input.Substring(3, 1);
            return output;
        }
    }
}
