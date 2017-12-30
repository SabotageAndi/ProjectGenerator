using Xunit;

namespace ProjectGenerator.Tests
{
    public class ProjectTests
    {
        [Fact]
        public void CreateProject()
        {
            //ARRANGE
            var tempPath = TestHelper.CreateDirectoryAndIfNeededCleanIt();


            var project = Project.Create().WithName("CreateProject");
            var solution = Solution.Create().WithName("CreateProject_Solution").InFolder(tempPath).AddProject(project);

            var create = new Create();

            //ACT
            create.Solution(solution);

            //ASSERT
        }
    }
}
