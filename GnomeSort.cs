using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class GnomeSort<T> where T : IComparable<T>
    {
        public void Sort(List<T> sortable)
        {
            int i = 1;
            int j = 2;
            while (i < sortable.Count)
            {
                if (i == 0 || sortable[i - 1].CompareTo(sortable[i]) < 0)
                {
                    i = j;
                    j++;
                }
                else
                {
                    var temp = sortable[i];
                    sortable[i] = sortable[i - 1];
                    sortable[i - 1] = temp;
                    i--;
                }
            }
        }
    }
}
