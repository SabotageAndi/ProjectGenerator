using System;
using ProjectGenerator.Extensions;

namespace ProjectGenerator.DotNetCommands
{
    public abstract class BaseCommandBuilder
    {
        private const string ExecutablePath = "dotnet";

        public CommandBuilder Build()
        {
            return new CommandBuilder(ExecutablePath, BuildArguments());
        }

        protected abstract string BuildArguments();

        protected string AddArgument(string argumentsFormat, string option, string value)
        {
            if (value.IsNotNullOrWhiteSpace())
            {
                argumentsFormat += $" {option} '{value}'";
            }

            return argumentsFormat;
        }
    }
}
