using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageSender
{
    static class IEnumerableExtension
    {
        public static IEnumerable<T> TakeLast<T>(this IEnumerable<T> collection, int count)
        {
            if (collection == null) return null;
            if (count < 0) count = 0;

            LinkedList<T> linkedList = new LinkedList<T>();
            foreach (T item in collection)
            {
                linkedList.AddLast(item);
                if (linkedList.Count > count) linkedList.RemoveFirst();
            }
            return linkedList;
        }
    }
}
