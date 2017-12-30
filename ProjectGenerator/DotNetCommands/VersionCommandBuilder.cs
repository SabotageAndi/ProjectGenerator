namespace ProjectGenerator.DotNetCommands
{
    public class VersionCommandBuilder :  BaseCommandBuilder
    {
        public static VersionCommandBuilder Create()
        {
            return new VersionCommandBuilder();
        }

        protected override string BuildArguments()
        {
            return "--version";
        }
    }
}
