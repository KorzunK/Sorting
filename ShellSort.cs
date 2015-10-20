using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class ShellSort<T> where T : IComparable<T>
    {
        public void Sort(List<T> sortable)
        {
            int d = sortable.Count / 2;

            while (d > 0)
            {
                for (int i = 0; i < sortable.Count/2 - d; i++)
                {
                    var n = sortable[i];

                    for (int j = i; (j >= 0) && (sortable[j].CompareTo(n) > 0); j --)
                    {
                        var temp = sortable[j];
                        sortable[j] = sortable[j + d];
                        sortable[j + d] = temp;
                    }
                }
                d = d/2;
            }
        }
    }
}
