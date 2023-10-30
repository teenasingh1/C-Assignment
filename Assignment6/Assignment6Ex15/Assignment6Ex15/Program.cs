using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6Ex15
{
    public class Program
    {
        static void Main(string[] args)
        {
            Collection coll = new Collection();
            coll.Add("test");
            coll.Add("sad");
            coll.Remove("test");
            coll.Add("happy");
            coll.Add("test1");
            coll.Add("test2");
            coll.Remove("test1");
        }
    }
}
