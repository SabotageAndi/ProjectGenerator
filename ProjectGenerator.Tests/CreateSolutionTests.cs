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

        [Fact]
        public void SolutionIsCreated()
        {
            //ARRANGE
            var guid = Guid.NewGuid();

            _tempPath = TestHelper.CreateDirectoryAndIfNeededCleanIt();
            var solution = Solution.Create().InFolder(_tempPath).WithName($"TestSolution_{guid}");


            //ACT
            var create = new Create();
            create.Solution(solution);

            //ASSERT
            var solutionPath = Path.Combine(_tempPath, $"TestSolution_{guid}.sln");

            var solutionExists = File.Exists(solutionPath);
            solutionExists.ShouldBeTrue($"There is no solution file {solutionPath} existing");
        }
    }
}
