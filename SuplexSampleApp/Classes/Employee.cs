namespace SuplexSampleApp
{
    public class Employee
    {
        public Employee(int id)
        {
            Id = id;
        }

        /// <summary>
        /// Immutable Id
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Employee Full Name
        /// </summary>
        public string Name { get; set; }
    }
}