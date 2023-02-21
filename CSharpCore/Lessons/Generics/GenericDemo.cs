using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCore.Lessons.Generics;

internal class GenericDemo<T>
{
    public T GetValue()
    {
        var calculator = new Calculator<int>();
        var result = calculator.Add(1, 1);
        Console.WriteLine(result);
        return (T)Convert.ChangeType(calculator, typeof(T));
    }

    public T GetValue(T claxx)
    {
        if (claxx is Calculator<int>)
        {
            var calculator = new Calculator<int>();
            var result = calculator.Add(1, 1);
            Console.WriteLine(result);
            return (T)Convert.ChangeType(calculator, typeof(T));
        }
        else
        if (claxx is Calculator<int> calculator)
        {
            var result = calculator.Add(1, 1);
            Console.WriteLine(result);
            return (T)Convert.ChangeType(calculator, typeof(T));
        }

        return default;
    }
}
