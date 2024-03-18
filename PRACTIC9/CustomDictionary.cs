using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTIC9
{
    internal class CustomDictionary
    {
        private class Entry
        {
            public string Key { get; set; }
            public string Value { get; set; }
            public Entry? Next { get; set; } = null;
        }
        private Entry?[] enteries = new Entry?[20];
        private int size = 0;
        public int Size
        {
            get { return size; }
        }

        public string? Put(string key,string value)
        {
            var pos = Math.Abs(key.GetHashCode())% enteries.Length;
            var listHead = enteries[pos];

            if (listHead != null)
            {
                var current = listHead;

                while (current.Next != null && current.Key != key)
                {
                    current = current.Next;
                }
                if (current.Key == key)
                {
                    var oldValue = current.Value;
                    current.Value = value;

                    return oldValue;
                }
                else
                {
                    current.Next = new Entry { Key = key, Value = value };
                    size++;
                    return null;
                }
            }
            else
            {
                enteries[pos] = new Entry { Key = key, Value = value };
                size++;
                return null;
            }
        }

        public string Get(string key)
        {
            var pos = Math.Abs(key.GetHashCode()) % enteries.Length;
            var current = enteries[pos];

            while(current != null)
            {
                if(current.Key == key)
                {
                    return current.Value;
                }
                current = current.Next;
            }

            return null;
        }
        public string Remove(string key)
        {
            var pos = Math.Abs(key.GetHashCode()) % enteries.Length;
            var listHead = enteries[pos];

            if (listHead == null) return null;

            if (listHead.Key == key)
            {
                var oldValue = listHead.Value;
                enteries[pos] = listHead.Next;
                size--;
                return oldValue;
            }
            else
            {
                var current = listHead;

                while (current.Next != null)
                {
                    if (current.Next.Key == key)
                    {
                        var oldValue = current.Next.Value;
                        current.Next = current.Next.Next;
                        size--;
                        return oldValue;
                    }

                    current = current.Next;
                }
                return null;
            }
                
        }
        public override string ToString()
        {
            var result = "";
            for(var i = 0; i < enteries.Length; i++)
            {
                result += $"{i,2}:{Stringify(enteries[i])}\n";
            }
            return result;
        }
        private string Stringify(Entry? listHead)
        {
            var result = "";
            var current = listHead;

            while(current != null)
            {
                result += $"{current.Key} = {current.Value}{(current.Next != null ? "\t->\t" : "")}";
                current = current.Next;
            }

            return result;
        }
    }
}
