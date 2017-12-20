using ProjectGenerator.DotNetCommands;
using Shouldly;
using Xunit;

namespace ProjectGenerator.Tests.DotNetCommands
{
    public class NewProjectTests
    {
        [Fact]
        public void WithoutParameters()
        {
            var commandBuilder = DotNet.New().Project().Build();

            commandBuilder.ArgumentsFormat.ShouldBe("new classlib");
        }

        [Fact]
        public void UseTemplate()
        {
            var commandBuilder = DotNet.New().Project().UseTemplate("console").Build();

            commandBuilder.ArgumentsFormat.ShouldBe("new console");
        }
    }
}
