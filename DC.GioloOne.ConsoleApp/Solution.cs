using System;
using System.Collections.Generic;
using System.Text;

namespace DC.GioloOne.ConsoleApp
{
    public class Solution
    {
        public string Solve(string input)
        {
            string inputWithSpacesRemoved = input.Replace(" ", "");
            string output = null;
            double rows = Math.Floor(Math.Sqrt(inputWithSpacesRemoved.Length));
            double columns = Math.Ceiling(Math.Sqrt(inputWithSpacesRemoved.Length));

            for (int i = 0; i < columns; i++)
            {
                for (int j = i; j < inputWithSpacesRemoved.Length; j += (int)columns)
                {
                    output += inputWithSpacesRemoved.Substring(j, 1);
                }

                if (i < columns - 1)
                    output += " ";
            }
            return output;
        }
    }
}
