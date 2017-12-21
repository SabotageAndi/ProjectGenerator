using System.Linq;
using System.Collections.Generic;

namespace ProjectGenerator
{
    public class Solution
    {
        public Solution()
        {
            Projects = new List<Project>();
        }

        public static Solution Create()
        {
            return new Solution();
        }

        public Solution AddProject(Project project)
        {
            var newSolution = (Solution) this.MemberwiseClone();
            var newProjects = new List<Project>(newSolution.Projects);
            newProjects.Add(project);
            newSolution.Projects = newProjects;
            return newSolution;
        }

        public Solution InFolder(string rootPath)
        {
            var newSolution = CloneSolution();
            newSolution.RootPath = rootPath;

            return newSolution;
        }

        private Solution CloneSolution()
        {
            return (Solution) this.MemberwiseClone();
        }

        public Solution WithName(string name)
        {
            var newSolution = CloneSolution();
            newSolution.Name = name;
            return newSolution;
        }

        public string RootPath { get; private set; }

        public string Name { get; private set; }


        public IReadOnlyCollection<Project> Projects { get; private set; }
    }
}
