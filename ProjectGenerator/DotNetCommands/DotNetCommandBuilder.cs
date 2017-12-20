using System;

namespace ProjectGenerator.DotNetCommands
{
    public partial class NewCommandBuilder
    {

        internal static NewCommandBuilder Create()
        {
            return new NewCommandBuilder();
        }

        public NewSolutionCommandBuilder Solution()
        {
            return new NewSolutionCommandBuilder(this);
        }

        public NewProjectCommandBuilder Project()
        {
            return new NewProjectCommandBuilder(this);
        }
    }
}
