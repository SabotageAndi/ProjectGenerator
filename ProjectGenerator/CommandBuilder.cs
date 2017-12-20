using System;

namespace ProjectGenerator
{
    public class CommandBuilder
    {
        public CommandBuilder(string executablePath, string argumentsFormat)
        {
            ExecutablePath = executablePath;
            ArgumentsFormat = argumentsFormat;
        }

        public string ArgumentsFormat {get;private set;}
        public string ExecutablePath {get;private set;}

        public void Execute()
        {
            using (var solutionCreateProcessHelper = new ProcessHelper())
            {
                var exitCode = solutionCreateProcessHelper.RunProcess(ExecutablePath, ArgumentsFormat);

                if (exitCode > 0)
                {
                    throw new Exception(solutionCreateProcessHelper.ConsoleOutput);
                }
            }
        }
    }
}
