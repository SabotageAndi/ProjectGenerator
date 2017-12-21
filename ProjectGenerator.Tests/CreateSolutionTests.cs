using Xunit;
using System.IO;
using Shouldly;
using System;
using System.Runtime.CompilerServices;

namespace ProjectGenerator.Tests
{
    public class CreateSolutionTests : IDisposable
    {
        private string _tempPath;

       
        public void Dispose()
        {
            if (Directory.Exists(_tempPath))
            {
                Directory.Delete(_tempPath, true);
            }
        }

        private string CleanupTestDirectory([CallerMemberName] string testName = null)
        {
            string testProjectPath = Path.Combine(Path.GetTempPath(), testName ?? "Test");

            if (Directory.Exists(testProjectPath))
            {
                Directory.Delete(testProjectPath, true);
            }

            return testProjectPath;
        }

        [Fact]
        public void SolutionIsCreated()
        {
            //ARRANGE
            _tempPath = CleanupTestDirectory();
            var solution = Solution.Create().InFolder(_tempPath).WithName("TestSolution");
             

            //ACT
            var create = new Create();
            create.Solution(solution);

            //ASSERT
            var solutionPath = Path.Combine(_tempPath, "TestSolution.sln");

            var solutionExists = File.Exists(solutionPath);
            solutionExists.ShouldBeTrue($"There is no solution file {solutionPath} existing");
        }
    }
}
