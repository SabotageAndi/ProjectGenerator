using System;
using System.IO;
using ProjectGenerator.DotNetCommands;

namespace ProjectGenerator
{
    public class Create
    {
        public void Solution(Solution solution)
        {
            if (Directory.Exists(solution.RootPath))
            {
                throw new Exception($"Folder {solution.RootPath} is not empty!");
            }

            Directory.CreateDirectory(solution.RootPath);

            DotNet.New().Solution().WithName(solution.Name).InFolder(solution.RootPath).Build().Execute();

            foreach (var project in solution.Projects)
            {
                Project(project);
            }
        }

        private void Project(Project project)
        {

        }
    }
}
