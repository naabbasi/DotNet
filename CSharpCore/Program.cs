using CSharpCore.Lessons;
using CSharpCore.Lessons.Classes.Partial;
using CSharpCore.Lessons.Classes.Record;
using CSharpCore.Lessons.Classes.Struct;
using CSharpCore.Lessons.Extensions;
using CSharpCore.Lessons.Generics;
using log4net;

internal class Program
{
    private static readonly ILog LOG = LogManager.GetLogger(typeof(Program));

    [Flags]
    private enum Days
    {
        None = 0,  // 0
        Monday = 1,  // 1
        Tuesday = 2,  // 2
        Wednesday = 4,  // 4
        Thursday = 8,  // 8
        Friday = 16,  // 16
        Saturday = 32,  // 32
        Sunday = 64,  // 64
        Weekend = Saturday | Sunday
    }

    private static void Main(string[] args)
    {
        Program program = new Program();
        string numberAsString = "12345";
        int number = int.Parse(numberAsString);
        Console.WriteLine("Number = {0}", number);
        LOG.Info($"Number = {number}");

        var item = (Name: "eggplant", Price: 1.99m, perPackage: 3);
        var date = DateTime.Now;
        Console.WriteLine($"On {date}, the price of {item.Name} was {item.Price} per {item.perPackage} items.");
        Console.WriteLine($"On {date:d}, the price of {item.Name} was {item.Price:C2} per {item.perPackage} items");
        Console.WriteLine($"[{DateTime.Now,-20:d}] Hour [{DateTime.Now,-10:HH}] [{1063.342,15:N2}] feet");

        var inventory = new Dictionary<string, int>()
        {
            ["hammer, ball pein"] = 18,
            ["hammer, cross pein"] = 5,
            ["screwdriver, Phillips #2"] = 14
        };

        Console.WriteLine($"Inventory on {DateTime.Now:d}");
        Console.WriteLine(" ");
        Console.WriteLine($"|{"Item",-25}|{"Quantity",10}|");
        foreach (var itemRow in inventory)
            Console.WriteLine($"|{itemRow.Key,-25}|{itemRow.Value,10}|");

        IEnumerable<KeyValuePair<string, int>> query = from itemRow in inventory
        where itemRow.Value > 10
        select itemRow;

        Person person1 = new("Noman","Ali") { PhoneNumbers = new string[1] };
        person1.PhoneNumbers[0] = "74715761";
        Console.WriteLine(person1);
        Console.WriteLine(person1.PhoneNumbers[0]);

        Person person2 = person1 with { PhoneNumbers = new string[] { "74715762" } };
        Console.WriteLine(person2.PhoneNumbers[0]);

        Employee employee = new Employee("Noman", "Ali");
        Console.WriteLine(employee);

        Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday;
        Console.WriteLine(meetingDays);

        bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;
        Console.WriteLine($"Is there a meeting on Tuesday: {isMeetingOnTuesday}");

        string s = "Hello Extension Methods";
        int i = s.WordCount();
        Console.WriteLine($"Total words found {i}");

        var result = AsyncSample.GetAsyncString().Result;
        Console.WriteLine(result);

        Divide(10, 3, out int res, out int rem);
        Console.WriteLine($"{res} {rem}");  // "3 1"

        Console.WriteLine(program.func("Noman Ali Abbasi"));

        var func1 = (string name) => $"My name is {name}";
        Console.WriteLine(func1("Noman Ali Abbasi"));

        GenericDemo<Calculator<int>> genericDemo = new GenericDemo<Calculator<int>>();
        genericDemo.GetValue();
        genericDemo.GetValue(new Calculator<int>());

        Calculator<int> intCalculator = new Calculator<int>();
        Console.WriteLine(intCalculator.Add(1, 3));

        Calculator<double> doubleCalculator = new Calculator<double>();        
        Console.WriteLine($"{doubleCalculator.Add(1.5,5.9)}");

        User partialUser = new() { UserId = 1, Username = "Noman Ali", Lastname = "Abbasi"};
        Console.WriteLine($"This is a partial user: {partialUser}");
        Console.WriteLine(partialUser.ExFullName());
    }

    Func<string, string> func = (string name) => $"My name is {name}";

    static void Divide(int x, int y, out int result, out int remainder)
    {
        result = x / y;
        remainder = x % y;
    }
}