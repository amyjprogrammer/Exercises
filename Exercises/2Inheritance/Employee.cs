namespace Exercises._1Classes
{
    class Employee : Person
    {
        public Employee(string name, string department) : base(name)
        {
            Department = department;
        }
        public string Department { get; set; }
    }
}
