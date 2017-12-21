using System;

namespace ProjectGenerator.DotNetCommands
{
    public partial class SolutionCommandBuilder
    {
        public static SolutionCommandBuilder Create()
        {
            return new SolutionCommandBuilder();
        }

        public AddProjectSolutionCommandBuilder AddProject()
        {
            return new AddProjectSolutionCommandBuilder(this);
        }
    }
}
