using Xunit;
using ProjectGenerator;
using Shouldly;

namespace ProjectGenerator.Tests
{
    public class SolutionPropertyTests
    {
        [Fact]
        public void OnlyCreated_AllPropertiesAreNull()
        {
            var solution = Solution.Create();


            solution.RootPath.ShouldBeNull();
            solution.Name.ShouldBeNull();
        }

        [Fact]
        public void WithName()
        {
            var solution = Solution.Create().WithName("TestSolution");

            solution.Name.ShouldBe("TestSolution");
        }

        [Fact]
        public void InFolder()
        {
            var solution = Solution.Create().InFolder("/rootfolder/");

            solution.RootPath.ShouldBe("/rootfolder/");
        }
    }
}
