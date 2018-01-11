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

            DotNet.New().Solution().WithName(solution.Name).InFolder(solution.RootPath).Build().Execute();

            foreach (var project in solution.Projects)
            {
                Project(project, solution);
            }
        }

        private void Project(Project project, Solution solution)
        {
            DotNet.New().Project().UseTemplate(project.Template).InFolder(Path.Combine(solution.RootPath, project.Name)).WithName(project.Name).Build().Execute();
        }
    }
}
