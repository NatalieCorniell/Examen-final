using System;
using System.Collections.Generic;

namespace Covid19
{
    public class CRUD
    {
        public CRUD()
        {
        }
        public static void Add<T>(List<T> list, T item)
        {
            list.Add(item);
        }
        public static T GetElement<T>(List<T> list, int index)
        {
            return list[index];
        }
    }
}
