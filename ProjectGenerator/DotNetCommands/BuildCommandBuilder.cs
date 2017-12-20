using System;

namespace ProjectGenerator.DotNetCommands
{

    public class BuildCommandBuilder : BaseCommandBuilder
    {
        internal static BuildCommandBuilder Create()
        {
            return new BuildCommandBuilder();
        }

        protected override string BuildArguments()
        {
            return "build";
        }
    }

}
