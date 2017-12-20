using ProjectGenerator.DotNetCommands;
using Shouldly;
using Xunit;

namespace ProjectGenerator.Tests.DotNetCommands
{
    public class NewSolutionTests
    {
        [Fact]
        public void WithoutParameters()
        {
            var commandBuilder = DotNet.New().Solution().Build();

            commandBuilder.ExecutablePath.ShouldBe("dotnet");
            commandBuilder.ArgumentsFormat.ShouldBe("new sln");
        }

        [Fact]
        public void WithName()
        {
            var commandBuilder = DotNet.New().Solution().WithName("SolutionName").Build();
            commandBuilder.ArgumentsFormat.ShouldBe("new sln -n SolutionName");
        }

         [Fact]
        public void InFolder()
        {
            var commandBuilder = DotNet.New().Solution().InFolder("/rootfolder/").Build();
            commandBuilder.ArgumentsFormat.ShouldBe("new sln -o /rootfolder/");
        }
    }
}
