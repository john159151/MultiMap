using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimapByJohn
{
    class Multimap<KeyType, ValueType>
    {
        private Dictionary<KeyType, HashSet<ValueType>> multimap;

        public Multimap()
        {
            multimap = new Dictionary<KeyType, HashSet<ValueType>>();
        }

        public void Add(KeyType key, ValueType value)
        {
            if (!multimap.ContainsKey(key))
            {
                HashSet<ValueType> valueSet = new HashSet<ValueType>();
                valueSet.Add(value);
                multimap.Add(key, valueSet);
            }
            else
            {
                HashSet<ValueType> valueSet = multimap[key];
                valueSet.Add(value);
            }
        }

        public bool Contains(KeyType key, ValueType value)
        {
            if (multimap.ContainsKey(key))
            {
                HashSet<ValueType> valueSet = multimap[key];
                if (valueSet.Contains(value))
                {
                    return true;
                }
            }
            return false;
        }

        public String ToString()
        {
            String str = "";
            foreach(KeyType key in multimap.Keys)
            {
                HashSet<ValueType> valueSet = multimap[key];
                foreach(ValueType value in valueSet)
                {
                    if (str.Length != 0)
                    {
                        str = str + ", ";
                    }
                    str = str + "(" + key + ", " + value + ")";
                }
            }
            return "[" + str + "]";
        }
    }
}
