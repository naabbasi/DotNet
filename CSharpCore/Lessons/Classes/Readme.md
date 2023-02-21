```
Short version
Can your data type be a value type? Go with struct. No? Does your type describe a value-like, preferably immutable state? Go with record.

Use class otherwise. So...

Yes, use records for your DTOs if it is one way flow.
Yes, immutable request bindings are an ideal user case for a record
Yes, SearchParameters are an ideal user case for a record.
For further practical examples of record use, you can check this repo.

Long version
A struct, a class and a record are user data types.

Structures are value types. Classes are reference types. Records are by default immutable reference types.

When you need some sort of hierarchy to describe your data types like inheritance or a struct pointing to another struct or basically things pointing to other things, you need a reference type.

Records solve the problem when you want your type to be a value oriented by default. Records are reference types but with the value oriented semantic.

With that being said, ask yourself these questions...

Does your data type respect all of these rules:

It logically represents a single value, similar to primitive types (int, double, etc.).
It has an instance size under 16 bytes.
It is immutable.
It will not have to be boxed frequently.
Yes? It should be a struct.
No? It should be some reference type.
Does your data type encapsulate some sort of a complex value? Is the value immutable? Do you use it in unidirectional (one way) flow?

Yes? Go with record.
No? Go with class.
BTW: Don't forget about anonymous objects. There will be an anonymous records in C# 10.0.

Notes
A record instance can be mutable if you make it mutable.

class Program
{
    static void Main()
    {
        var test = new Foo("a");
        Console.WriteLine(test.MutableProperty);
        test.MutableProperty = 15;
        Console.WriteLine(test.MutableProperty);
        //test.Bar = "new string"; // will not compile
    }
}

public record Foo(string Bar)
{
    public double MutableProperty { get; set; } = 10.0;
}
An assignment of a record is a shallow copy of the record. A copy by with expression of a record is neither a shallow nor a deep copy. The copy is created by a special clone method emitted by C# compiler. Value-type members are copied and boxed. Reference-type members are pointed to the same reference. You can do a deep copy of a record if and only if the record has value type properties only. Any reference type member property of a record is copied as a shallow copy.

See this example (using top-level feature in C# 9.0):

using System.Collections.Generic;
using static System.Console;

var foo = new SomeRecord(new List<string>());
var fooAsShallowCopy = foo;
var fooAsWithCopy = foo with { }; // A syntactic sugar for new SomeRecord(foo.List);
var fooWithDifferentList = foo with { List = new List<string>() { "a", "b" } };
var differentFooWithSameList = new SomeRecord(foo.List); // This is the same like foo with { };
foo.List.Add("a");

WriteLine($"Count in foo: {foo.List.Count}"); // 1
WriteLine($"Count in fooAsShallowCopy: {fooAsShallowCopy.List.Count}"); // 1
WriteLine($"Count in fooWithDifferentList: {fooWithDifferentList.List.Count}"); // 2
WriteLine($"Count in differentFooWithSameList: {differentFooWithSameList.List.Count}"); // 1
WriteLine($"Count in fooAsWithCopy: {fooAsWithCopy.List.Count}"); // 1
WriteLine("");

WriteLine($"Equals (foo & fooAsShallowCopy): {Equals(foo, fooAsShallowCopy)}"); // True. The lists inside are the same.
WriteLine($"Equals (foo & fooWithDifferentList): {Equals(foo, fooWithDifferentList)}"); // False. The lists are different
WriteLine($"Equals (foo & differentFooWithSameList): {Equals(foo, differentFooWithSameList)}"); // True. The list are the same.
WriteLine($"Equals (foo & fooAsWithCopy): {Equals(foo, fooAsWithCopy)}"); // True. The list are the same, see below.
WriteLine($"ReferenceEquals (foo.List & fooAsShallowCopy.List): {ReferenceEquals(foo.List, fooAsShallowCopy.List)}"); // True. The records property points to the same reference.
WriteLine($"ReferenceEquals (foo.List & fooWithDifferentList.List): {ReferenceEquals(foo.List, fooWithDifferentList.List)}"); // False. The list are different instances.
WriteLine($"ReferenceEquals (foo.List & differentFooWithSameList.List): {ReferenceEquals(foo.List, differentFooWithSameList.List)}"); // True. The records property points to the same reference.
WriteLine($"ReferenceEquals (foo.List & fooAsWithCopy.List): {ReferenceEquals(foo.List, fooAsWithCopy.List)}"); // True. The records property points to the same reference.
WriteLine("");

WriteLine($"ReferenceEquals (foo & fooAsShallowCopy): {ReferenceEquals(foo, fooAsShallowCopy)}"); // True. !!! fooAsCopy is pure shallow copy of foo. !!!
WriteLine($"ReferenceEquals (foo & fooWithDifferentList): {ReferenceEquals(foo, fooWithDifferentList)}"); // False. These records are two different reference variables.
WriteLine($"ReferenceEquals (foo & differentFooWithSameList): {ReferenceEquals(foo, differentFooWithSameList)}"); // False. These records are two different reference variables and reference type property hold by these records does not matter in ReferenceEqual.
WriteLine($"ReferenceEquals (foo & fooAsWithCopy): {ReferenceEquals(foo, fooAsWithCopy)}"); // False. The same story as differentFooWithSameList.
WriteLine("");

var bar = new RecordOnlyWithValueNonMutableProperty(0);
var barAsShallowCopy = bar;
var differentBarDifferentProperty = bar with { NonMutableProperty = 1 };
var barAsWithCopy = bar with { };

WriteLine($"Equals (bar & barAsShallowCopy): {Equals(bar, barAsShallowCopy)}"); // True.
WriteLine($"Equals (bar & differentBarDifferentProperty): {Equals(bar, differentBarDifferentProperty)}"); // False. Remember, the value equality is used.
WriteLine($"Equals (bar & barAsWithCopy): {Equals(bar, barAsWithCopy)}"); // True. Remember, the value equality is used.
WriteLine($"ReferenceEquals (bar & barAsShallowCopy): {ReferenceEquals(bar, barAsShallowCopy)}"); // True. The shallow copy.
WriteLine($"ReferenceEquals (bar & differentBarDifferentProperty): {ReferenceEquals(bar, differentBarDifferentProperty)}"); // False. Operator with creates a new reference variable.
WriteLine($"ReferenceEquals (bar & barAsWithCopy): {ReferenceEquals(bar, barAsWithCopy)}"); // False. Operator with creates a new reference variable.
WriteLine("");

var fooBar = new RecordOnlyWithValueMutableProperty();
var fooBarAsShallowCopy = fooBar; // A shallow copy, the reference to bar is assigned to barAsCopy
var fooBarAsWithCopy = fooBar with { }; // A deep copy by coincidence because fooBar has only one value property which is copied into barAsDeepCopy.

WriteLine($"Equals (fooBar & fooBarAsShallowCopy): {Equals(fooBar, fooBarAsShallowCopy)}"); // True.
WriteLine($"Equals (fooBar & fooBarAsWithCopy): {Equals(fooBar, fooBarAsWithCopy)}"); // True. Remember, the value equality is used.
WriteLine($"ReferenceEquals (fooBar & fooBarAsShallowCopy): {ReferenceEquals(fooBar, fooBarAsShallowCopy)}"); // True. The shallow copy.
WriteLine($"ReferenceEquals (fooBar & fooBarAsWithCopy): {ReferenceEquals(fooBar, fooBarAsWithCopy)}"); // False. Operator with creates a new reference variable.
WriteLine("");

fooBar.MutableProperty = 2;
fooBarAsShallowCopy.MutableProperty = 3;
fooBarAsWithCopy.MutableProperty = 3;
WriteLine($"fooBar.MutableProperty = {fooBar.MutableProperty} | fooBarAsShallowCopy.MutableProperty = {fooBarAsShallowCopy.MutableProperty} | fooBarAsWithCopy.MutableProperty = {fooBarAsWithCopy.MutableProperty}"); // fooBar.MutableProperty = 3 | fooBarAsShallowCopy.MutableProperty = 3 | fooBarAsWithCopy.MutableProperty = 3
WriteLine($"Equals (fooBar & fooBarAsShallowCopy): {Equals(fooBar, fooBarAsShallowCopy)}"); // True.
WriteLine($"Equals (fooBar & fooBarAsWithCopy): {Equals(fooBar, fooBarAsWithCopy)}"); // True. Remember, the value equality is used. 3 != 4
WriteLine($"ReferenceEquals (fooBar & fooBarAsShallowCopy): {ReferenceEquals(fooBar, fooBarAsShallowCopy)}"); // True. The shallow copy.
WriteLine($"ReferenceEquals (fooBar & fooBarAsWithCopy): {ReferenceEquals(fooBar, fooBarAsWithCopy)}"); // False. Operator with creates a new reference variable.
WriteLine("");

fooBarAsWithCopy.MutableProperty = 4;
WriteLine($"fooBar.MutableProperty = {fooBar.MutableProperty} | fooBarAsShallowCopy.MutableProperty = {fooBarAsShallowCopy.MutableProperty} | fooBarAsWithCopy.MutableProperty = {fooBarAsWithCopy.MutableProperty}"); // fooBar.MutableProperty = 3 | fooBarAsShallowCopy.MutableProperty = 3 | fooBarAsWithCopy.MutableProperty = 4
WriteLine($"Equals (fooBar & fooBarAsWithCopy): {Equals(fooBar, fooBarAsWithCopy)}"); // False. Remember, the value equality is used. 3 != 4
WriteLine("");

var venom = new MixedRecord(new List<string>(), 0); // Reference/Value property, mutable non-mutable.
var eddieBrock = venom;
var carnage = venom with { };
venom.List.Add("I'm a predator.");
carnage.List.Add("All I ever wanted in this world is a carnage.");
WriteLine($"Count in venom: {venom.List.Count}"); // 2
WriteLine($"Count in eddieBrock: {eddieBrock.List.Count}"); // 2
WriteLine($"Count in carnage: {carnage.List.Count}"); // 2
WriteLine($"Equals (venom & eddieBrock): {Equals(venom, eddieBrock)}"); // True.
WriteLine($"Equals (venom & carnage): {Equals(venom, carnage)}"); // True. Value properties has the same values, the List property points to the same reference.
WriteLine($"ReferenceEquals (venom & eddieBrock): {ReferenceEquals(venom, eddieBrock)}"); // True. The shallow copy.
WriteLine($"ReferenceEquals (venom & carnage): {ReferenceEquals(venom, carnage)}"); // False. Operator with creates a new reference variable.
WriteLine("");

eddieBrock.MutableList = new List<string>();
eddieBrock.MutableProperty = 3;
WriteLine($"Equals (venom & eddieBrock): {Equals(venom, eddieBrock)}"); // True. Reference or value type does not matter. Still a shallow copy of venom, still true.
WriteLine($"Equals (venom & carnage): {Equals(venom, carnage)}"); // False. the venom.List property does not points to the same reference like in carnage.List anymore.
WriteLine($"ReferenceEquals (venom & eddieBrock): {ReferenceEquals(venom, eddieBrock)}"); // True. The shallow copy.
WriteLine($"ReferenceEquals (venom & carnage): {ReferenceEquals(venom, carnage)}"); // False. Operator with creates a new reference variable.
WriteLine($"ReferenceEquals (venom.List & carnage.List): {ReferenceEquals(venom.List, carnage.List)}"); // True. Non mutable reference type.
WriteLine($"ReferenceEquals (venom.MutableList & carnage.MutableList): {ReferenceEquals(venom.MutableList, carnage.MutableList)}"); // False. This is why Equals(venom, carnage) returns false.
WriteLine("");


public record SomeRecord(List<string> List);

public record RecordOnlyWithValueNonMutableProperty(int NonMutableProperty);

public record RecordOnlyWithValueMutableProperty
{
    public int MutableProperty { get; set; } = 1; // this property gets boxed
}

public record MixedRecord(List<string> List, int NonMutableProperty)
{
    public List<string> MutableList { get; set; } = new();
    public int MutableProperty { get; set; } = 1; // this property gets boxed
}
The performance penalty is obvious here. A larger data to copy in a record instance you have, a larger performance penalty you get. Generally, you should create small, slim classes and this rule applies to records too.

If your application is using database or file system, I wouldn't worry about this penalty much. The database/file system operations are generally slower.

I made some synthetic test (full code below) where classes are wining but in real life application, the impact should be unnoticeable.

In addition, the performance is not always number one priority. These days, the maintainability and readability of your code is preferable than highly optimized spaghetti code. It is the code author choice which way (s)he would prefer.

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace SmazatRecord
{
    class Program
    {
        static void Main()
        {
            var summary = BenchmarkRunner.Run<Test>();
        }
    }

    public class Test
    {

        [Benchmark]
        public int TestRecord()
        {
            var foo = new Foo("a");
            for (int i = 0; i < 10000; i++)
            {
                var bar = foo with { Bar = "b" };
                bar.MutableProperty = i;
                foo.MutableProperty += bar.MutableProperty;
            }
            return foo.MutableProperty;
        }

        [Benchmark]
        public int TestClass()
        {
            var foo = new FooClass("a");
            for (int i = 0; i < 10000; i++)
            {
                var bar = new FooClass("b")
                {
                    MutableProperty = i
                };
                foo.MutableProperty += bar.MutableProperty;
            }
            return foo.MutableProperty;
        }
    }

    public record Foo(string Bar)
    {
        public int MutableProperty { get; set; } = 10;
    }

    public class FooClass
    {
        public FooClass(string bar)
        {
            Bar = bar;
        }
        public int MutableProperty { get; set; }
        public string Bar { get; }
    }
}
Result:

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1379 (1909/November2018Update/19H2)
AMD FX(tm)-8350, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.103
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  DefaultJob : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT


Method	Mean	Error	StdDev
TestRecord	120.19 μs	2.299 μs	2.150 μs
TestClass	98.91 μs	0.856 μs	0.800 μs
```