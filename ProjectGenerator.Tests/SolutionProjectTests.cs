using Xunit;
using ProjectGenerator;
using Shouldly;

namespace ProjectGenerator.Tests
{
    public class SolutionProjectTests
    {
        [Fact]
        public void AddProjectToEmtpyList()
        {
            var solution = Solution.Create();
            var project = Project.Create();

            var newSolution = solution.AddProject(project);

            newSolution.Projects.Count.ShouldBe(1);
            newSolution.Projects.ShouldContain(project);
        }

        [Fact]
        public void AddProjectToAlreadyFilledList()
        {
            var solution = Solution.Create();
            solution = solution.AddProject(Project.Create());
            var project = Project.Create();

            var newSolution = solution.AddProject(project);

            newSolution.Projects.Count.ShouldBe(2);
            newSolution.Projects.ShouldContain(project);
        }
    }
}
