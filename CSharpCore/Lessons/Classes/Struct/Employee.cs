namespace CSharpCore.Lessons.Classes.Struct
{
    public struct Employee
    {
        private readonly string _firstName;
        private readonly string _lastName;

        public Employee()
        {
            _firstName = "";
            _lastName = "";
        }

        public Employee(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        
        public override string ToString() => $"{_firstName} {_lastName}";
    }
}
