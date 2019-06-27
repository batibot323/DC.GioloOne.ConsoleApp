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
            //output += input.Substring(0, 1);
            //output += input.Substring(2, 1);
            //output += " ";
            //output += input.Substring(1, 1);
            //output += input.Substring(3, 1);
            double rows = Math.Ceiling(Math.Sqrt(input.Length));
            double columns = Math.Floor(Math.Sqrt(input.Length));

            for (int i = 0; i <= columns; i++)
            {
                for (int j = i; j < input.Length; j += (int)columns)
                {
                    output += input.Substring(j, 1);
                }

                output += " ";
            }
            return output;
        }
    }
}
