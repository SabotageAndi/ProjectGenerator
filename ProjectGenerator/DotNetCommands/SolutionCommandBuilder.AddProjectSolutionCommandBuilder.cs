using ProjectGenerator.Extensions;

namespace ProjectGenerator.DotNetCommands
{
    public partial class SolutionCommandBuilder
    {
        public class AddProjectSolutionCommandBuilder : BaseCommandBuilder
        {
            private SolutionCommandBuilder _solutionCommandBuilder;
            private string _solutionPath;
            private string _projectPath;

            public AddProjectSolutionCommandBuilder(SolutionCommandBuilder solutionCommandBuilder)
            {
                _solutionCommandBuilder = solutionCommandBuilder;
            }

            public AddProjectSolutionCommandBuilder ToSolution(string solutionPath)
            {
                _solutionPath = solutionPath;
                return this;
            }

            public AddProjectSolutionCommandBuilder Project(string projectPath)
            {
                _projectPath = projectPath;
                return this;
            }

            protected override string BuildArguments()
            {
                if (_solutionPath.IsNullOrWhiteSpace()) throw new System.ArgumentNullException("Solution is not set");
                if (_projectPath.IsNullOrWhiteSpace()) throw new System.ArgumentNullException("Project is not set");

                var arguments = $"sln \"{_solutionPath}\" add \"{_projectPath}\"";

                return arguments;
            }
        }
    }
}
