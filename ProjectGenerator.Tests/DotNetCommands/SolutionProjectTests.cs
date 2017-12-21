using Xunit;
using ProjectGenerator;
using Shouldly;
using ProjectGenerator.DotNetCommands;

namespace ProjectGenerator.Tests.DotNetCommands
{
    public class SolutionProjectTests
    {
        [Fact]
        public void AddProjectToSolutionTest()
        {
            var command =  DotNet.Solution().AddProject().ToSolution("solutionPath").Project("projectPath").Build();

            command.ArgumentsFormat.ShouldBe("sln \"solutionPath\" add \"projectPath\"");
        }
    }
}
