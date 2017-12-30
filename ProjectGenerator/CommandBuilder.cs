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

        public string ArgumentsFormat { get; private set; }
        public string ExecutablePath { get; private set; }

        public CommandResult Execute()
        {
            using (var solutionCreateProcessHelper = new ProcessHelper())
            {
                var exitCode = solutionCreateProcessHelper.RunProcess(ExecutablePath, ArgumentsFormat);

                if (exitCode > 0)
                {
                    var innerException = new Exception(solutionCreateProcessHelper.ConsoleOutput);
                    throw new Exception($"Error while executing {ExecutablePath} {ArgumentsFormat}", innerException);
                }

                return new CommandResult(exitCode, solutionCreateProcessHelper.ConsoleOutput);
            }
        }
    }

    public class CommandResult
    {
        public CommandResult(int exitCode, string consoleOutput)
        {
            ExitCode = exitCode;
            ConsoleOutput = consoleOutput;
        }
        public string ConsoleOutput { get; private set; }
        public int ExitCode { get; private set; }
    }
}
