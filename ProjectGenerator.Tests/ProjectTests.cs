using System;
using System.IO;
using Xunit;

namespace ProjectGenerator.Tests
{
    public class ProjectTests : IDisposable
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
        public void CreateProject()
        {
            //ARRANGE
            _tempPath = TestHelper.CreateDirectoryAndIfNeededCleanIt();


            var project = Project.Create().WithName("CreateProject");
            var solution = Solution.Create().WithName("CreateProject_Solution").InFolder(_tempPath).AddProject(project);

            var create = new Create();

            //ACT
            create.Solution(solution);

            //ASSERT
        }
    }
}
