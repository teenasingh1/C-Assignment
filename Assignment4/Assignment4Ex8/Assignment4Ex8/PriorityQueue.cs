
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment4Ex8
{
    class PriorityQueue<T> where T : IEquatable<T>
    {
        private IDictionary<int, IList<T>> elements;
        public PriorityQueue()
        {
            //costructor
            if (this.elements == null)
                this.elements = new Dictionary<int, IList<T>>();
        }
        
        //returns no.of elements in PQ
        public int Count()
        {
            int count = 0;
            foreach (KeyValuePair<int, IList<T>> item in elements)
            {
                count += item.Value.Count();
            }
            
            return count;
        }
        public bool Contains(T find)
        {
            foreach (KeyValuePair<int, IList<T>> item in elements)
            {
                if (item.Value.Contains(find)) return true;
            }
            return false;
        }
        public void Enqueue(int priority, T item)
        {
            IList<T> items;
            try
            {
                items = this.elements[priority];
            }
            catch (KeyNotFoundException ex)
            {
                this.elements.Add(priority, new List<T>());
            }
            finally
            {
                items = this.elements[priority];
                items.Add(item);
            }
        }
        public T Peek()
        {
            return elements[GetHighestPriority()][0];
        }
        public T Dequeue()
        {
            T item = elements[GetHighestPriority()][0];
            elements[GetHighestPriority()].RemoveAt(0);
            return item;
        }
        private int GetHighestPriority()
        {
            int maxKey = int.MinValue;
            foreach (KeyValuePair<int, IList<T>> item in elements)
            {
                if (maxKey < item.Key && elements[item.Key].Count() > 0) maxKey = item.Key;
            }
            return maxKey;
        }
    }
}

