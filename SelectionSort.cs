using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectionSort<T> where T : IComparable<T>
    {
        public void Sort(List<T> sortable)
        {
            for(int i = 0; i < sortable.Count - 1; i++)
            {
                int key = i;

                for(int j = i + 1; j < sortable.Count; j++)
                {
                    if (sortable[j].CompareTo(sortable[key]) == -1)
                    {
                        key = j;
                    }
                }

                var temp = sortable[i];
                sortable[i] = sortable[key];
                sortable[key] = temp;
            }
        }
    }
}
