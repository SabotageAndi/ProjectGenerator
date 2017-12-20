namespace ProjectGenerator
{
    public class Project
    {
        public Project(string name)
        {
            this.Name = name;

        }
        public string Name { get; private set; }
    }
}