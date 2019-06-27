using DC.GioloOne.ConsoleApp;
using System;
using Xunit;

namespace DC.GioloOne.Test
{
    public class SolutionTest
    {
        private Solution uut;

        public SolutionTest()
        {
            uut = new Solution();
        }

        [Fact]
        public void Solve_Given_abcd_ShouldReturn_ac_bd()
        {
            Assert.Equal("ac bd", uut.Solve("abcd"));
        }

        [Fact]
        public void Solve_Given_efgh_ShouldReturn_eg_fh()
        {
            Assert.Equal("eg fh", uut.Solve("efgh"));
        }

        [Fact]
        public void Solve_Given_abcde_ShouldReturn_ace_bd()
        {
            Assert.Equal("ad be c", uut.Solve("abcde"));
        }

        [Fact]
        public void Solve_Given_input_ShouldReturn_output()
        {
            string input = "if man was meant to stay on the ground god would have given us roots";
            string output = "imtgdvs fearwer mayoogo anouuio ntnnlvt wttddes aohghn sseoau";
            Assert.Equal(output, uut.Solve(input));
        }
    }
}
