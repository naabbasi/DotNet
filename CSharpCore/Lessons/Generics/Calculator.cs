using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCore.Lessons.Generics
{
    internal class Calculator<T>
    {
        public T Add(T v1, T v2)
        {
            if (v1 is int && v2 is int)
            {
                var result = Convert.ToInt64(v1) + Convert.ToInt64(v2);
                return (T)Convert.ChangeType(result, typeof(T));
            }
            else if (v1 is double && v2 is double)
            {
                var result = Convert.ToDouble(v1) + Convert.ToDouble(v2);
                return (T)Convert.ChangeType(result, typeof(T));
            }

            return default;
        }
    }
}
