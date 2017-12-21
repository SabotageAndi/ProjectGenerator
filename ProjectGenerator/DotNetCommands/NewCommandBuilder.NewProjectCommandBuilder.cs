using System;

namespace ProjectGenerator.DotNetCommands
{
    public partial class NewCommandBuilder
    {
        public class NewProjectCommandBuilder : BaseCommandBuilder
        {
            private readonly NewCommandBuilder _newCommandBuilder;
            private string _templateName = "classlib";

            public NewProjectCommandBuilder(NewCommandBuilder newCommandBuilder)
            {
                this._newCommandBuilder = newCommandBuilder;
            }

            public NewProjectCommandBuilder UseTemplate(string templateName)
            {
                _templateName = templateName;
                return this;
            }

            protected override string BuildArguments()
            {
                var arguments = $"new {_templateName}";


                return arguments;
            }
        }
    }
}
