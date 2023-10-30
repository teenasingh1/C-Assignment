
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment4Ex9
{
    public interface IPriority
    {
        //property
        int Priority { get; set; }
    }
    public class PriorityQueue2<T> : IPriority
    {
        public int Priority { get; set; }
        private Dictionary<int, List<T>> elements;

        
        //default constructor
        public PriorityQueue2()
        {
            this.elements = new Dictionary<int, List<T>>();
        }
        public void Enqueue(T item)
        {
            if (!this.elements.ContainsKey(Priority))
            {
                this.elements.Add(Priority, new List<T>());
            }
            this.elements[Priority].Add(item);
        }
        public T Dequeue()
        {
            var item = elements[GetHighestPriority()][0];
            elements[GetHighestPriority()].RemoveAt(0);
            return item;
        }
        public int Count()
        {
            int Count = 0;
            foreach (var item in elements)
            {
                Count += item.Value.Count;
            }
            return Count;
        }
        public bool Contain(T value)
        {
            foreach (var item in elements)
            {
                foreach (var item1 in item.Value)
                {
                    if (item1 != null && (item1.Equals(value))) return true;
                }
            }
            return false;
        }
        public bool Contains(T find)
        {
            foreach (var item in this.elements)
            {
                if (item.Value.Contains(find)) return true;
            }
            return false;
        }
        public T Peek() => elements[GetHighestPriority()][0];
        private int GetHighestPriority()
        {
            if (this.elements.Count() < 1)
                throw new Exception("Empty");
            int maxKey = int.MinValue;
            foreach (var item in elements)
            {
                if (maxKey < item.Key && elements[item.Key].Count() > 0) maxKey = item.Key;
            }
            return maxKey;
        }
    }
}


