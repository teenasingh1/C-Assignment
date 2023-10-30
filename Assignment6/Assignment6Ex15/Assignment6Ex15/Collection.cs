using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6Ex15
{
    class Collection
    {
        private ObservableCollection<string> collection = new ObservableCollection<string>();
        public Collection()
        {
            collection.CollectionChanged += HandleChange;
        }
        public void Add(string element)
        {
            collection.Add(element);
        }
        public void Remove(string element)
        {
            collection.Remove(element);
        }
        private void HandleChange(object source, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (var item in e.NewItems)
                {
                    System.Console.WriteLine("Element '{0}' is added in collection\n", item.ToString());
                }
            }
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (var item in e.OldItems)
                {
                    System.Console.WriteLine("Element '{0}' is removed in collection\n", item.ToString());
                }
            }
        }
    }


}
