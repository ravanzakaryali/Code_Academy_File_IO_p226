using System;
using System.Collections.Generic;
using System.Text;

namespace LabTask333.CustomList
{
    public class CustomList<T> 
    {
        public List<T> list { get; set; }
        public CustomList()
        {
            list = new List<T>();
        }
        public T CustomFind(Predicate<T> match)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (match(list[i]))
                {
                    return list[i];
                }
            }
            return default(T);
        }
        public CustomList<T> CustomFindAll(Predicate<T> match)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < list.Count; i++)
            {
                if (match(list[i]))
                {
                    newList.list.Add(list[i]);
                }
            }
            return newList;
        }
    }
}
