using System;

namespace ProjectGenerator.DotNetCommands
{
    public partial class NewCommandBuilder
    {
        public class NewProjectCommandBuilder : BaseCommandBuilder
        {
            private readonly NewCommandBuilder _newCommandBuilder;
            private string _templateName = "classlib";
            private string _name = "ClassLib";
            private string _folder;

            public NewProjectCommandBuilder(NewCommandBuilder newCommandBuilder)
            {
                this._newCommandBuilder = newCommandBuilder;
            }

            public NewProjectCommandBuilder UseTemplate(string templateName)
            {
                _templateName = templateName;
                return this;
            }

            public NewProjectCommandBuilder WithName(string name)
            {
                _name = name;
                return this;   
            }

            public NewProjectCommandBuilder InFolder(string folder)
            {
                _folder = folder;
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
