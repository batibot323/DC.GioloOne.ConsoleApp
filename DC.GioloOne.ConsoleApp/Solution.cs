using System;
using System.Collections.Generic;
using System.Text;

namespace DC.GioloOne.ConsoleApp
{
    public class Solution
    {
        public string Solve(string input)
        {
            string output = null;
            double rows = Math.Ceiling(Math.Sqrt(input.Length));
            double columns = Math.Floor(Math.Sqrt(input.Length));

            for (int i = 0; i < rows; i++)
            {
                for (int j = i; j < input.Length; j += (int)columns)
                {
                    output += input.Substring(j, 1);
                }

                if (i < rows - 1)
                    output += " ";
            }
            return output;
        }
    }
}
