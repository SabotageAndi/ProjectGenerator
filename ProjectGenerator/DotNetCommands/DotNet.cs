namespace ProjectGenerator.DotNetCommands
{
    public class DotNet
    {
        public static NewCommandBuilder New() => NewCommandBuilder.Create();
        public static BuildCommandBuilder Build() => BuildCommandBuilder.Create();
    }
}
