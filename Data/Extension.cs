using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revision.Data
{
    public static class Extension
    {
        public static List<T> FilterExtension<T>(this List<T> record, Func<T, bool> func)
        {
            List<T> filterList = new List<T>();
            foreach (T recordItem in record)
            {
                if (func(recordItem))
                {
                    filterList.Add(recordItem);
                }
            }
                return filterList;
        }
    }
}