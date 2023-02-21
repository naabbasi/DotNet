namespace CSharpCore.Lessons.Classes.Record
{
    public record Person(string FirstName, string LastName)
    {
        public double MutableProperty { get; set; } = 10.0;
        public string[] PhoneNumbers { get; init; }
    }
}
