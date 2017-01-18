using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class FrequencyArray<T>
    {
        public Dictionary<T, int> Value = new Dictionary<T, int>();

        public FrequencyArray(List<T> list)
        {
            foreach (T el in list)
            {
                if (!Value.ContainsKey(el))
                {
                    Value.Add(el, 1);
                }
                else
                {
                    Value[el] += 1;
                }
            }
        }

        public FrequencyArray(T[] array) : this(array.ToList()) { }

        public bool Equals(FrequencyArray<T> other)
        {
            foreach (var el in Value)
            {
                if (!other.Value.ContainsKey(el.Key) || other.Value[el.Key] != el.Value)
                {
                    return false;
                }
            }

            if(Value.Count != other.Value.Count)
            {
                return false;
            }

            return true;
        }
    }
}
