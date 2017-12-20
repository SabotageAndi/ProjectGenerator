using System.Collections.Generic;

namespace ProjectGenerator
{
    public class Solution
    {
        public string RootPath { get; }
        public Solution(string rootPath, string name)
        {
            this.RootPath = rootPath;
            Name = name;
            Projects = new List<Project>();
        }
        public string Name { get; private set; }


        public IReadOnlyCollection<Project> Projects { get; private set; }
    }
}