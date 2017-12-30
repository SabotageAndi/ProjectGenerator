using ProjectGenerator.DotNetCommands;
using Shouldly;
using Xunit;

namespace ProjectGenerator.Tests
{
    public class CheckInfrastructureTests
    {
        [Fact]
        public void CheckDotNetVersion()
        {
            var result = DotNet.Version().Build().Execute();

            result.ConsoleOutput.ShouldStartWith("2.1");
        }
    }
}
