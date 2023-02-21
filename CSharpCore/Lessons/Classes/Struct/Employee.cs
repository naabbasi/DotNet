namespace CSharpCore.Lessons.Classes.Struct
{
    public struct Employee
    {
        private string FirstName;
        private string LastName;

        public Employee()
        {
            FirstName = "";
            LastName = "";
        }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString() => $"{FirstName} {LastName}";
    }
}
