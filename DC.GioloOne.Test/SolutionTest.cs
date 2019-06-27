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
        public void Solve_Given_abcd_ShouldReturn_acbd()
        {
            Assert.Equal("acbd", uut.Solve("abcd"));
        }
    }
}
