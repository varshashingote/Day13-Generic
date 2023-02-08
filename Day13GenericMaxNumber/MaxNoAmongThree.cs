using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13GenericMaxNumber
{
    public class MaximumNumber<T> where T : IComparable
        {
            public T[] value;

            public MaximumNumber(T[] value)
            {
                this.value = value;
            }
            public T[] Sort(T[] values)
            {
                Array.Sort(value);

                return value;
            }

            public T MaxValue(params T[] values)
            {
                var sortedValue = Sort(values);
                return sortedValue[1];

            }
        
        }
    }