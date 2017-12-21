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

        public string Name { get; private set; }
    }
}
