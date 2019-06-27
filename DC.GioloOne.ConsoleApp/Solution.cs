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
            double rows = Math.Floor(Math.Sqrt(input.Length));
            double columns = Math.Ceiling(Math.Sqrt(input.Length));

            for (int i = 0; i < columns; i++)
            {
                for (int j = i; j < input.Length; j += (int)columns)
                {
                    output += input.Substring(j, 1);
                }

                if (i < columns - 1)
                    output += " ";
            }
            return output;
        }
    }
}
