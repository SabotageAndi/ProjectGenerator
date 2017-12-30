using System;

namespace ProjectGenerator
{
    public class Project
    {
        public static Project Create()
        {
            return new Project();
        }

        public Project()
        {
        }

        public Project(string name)
        {
            this.Name = name;
        }

        public Project WithName(string name)
        {
            var clone = Clone();
            clone.Name = name;

            return clone;
        }

        public string Name { get; private set; }

        protected Project Clone()
        {
            return (Project)this.MemberwiseClone();
        }
    }
}
