/* 1.Create your own  Dictionary which takes key , value pairs of type Generics. 
Support methods like  Add, Remove and Sort.  Try this out on various user defined types. */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic
{
    class GenericList<TKey, T1Value>
    {
        Dictionary<TKey, T1Value> _dict = new Dictionary<TKey, T1Value>();

        public void Add(TKey key, T1Value value) => _dict.Add(key, value);//adding to dictionary
        public void Remove(TKey key) => _dict.Remove(key);//removing elements using key
        public void sort()//sorting the dictionary
        {
            var list = _dict.Keys.ToList();
            list.Sort();
            foreach (var key in list)
            {
                Console.WriteLine("{0}: {1}", key, _dict[key]);

            }
        }
        public void print()
        {
            foreach (var item in _dict)
            {
                Console.WriteLine($"Key:{item.Key}\nValue:{item.Value}");
            }
        }
    }
}