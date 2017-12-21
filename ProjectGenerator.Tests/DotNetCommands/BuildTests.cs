using ProjectGenerator.DotNetCommands;
using Shouldly;
using Xunit;

namespace ProjectGenerator.Tests.DotNetCommands
{
    public class BuildTests
    {
        [Fact]
        public void WithoutParameters()
        {
            var commandBuilder = DotNet.Build().Build();

            commandBuilder.ArgumentsFormat.ShouldBe("build");
        }
    }
}
