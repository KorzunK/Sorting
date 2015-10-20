using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            var size = r.Next(-2, 5);
            var sortable = new List<int>();

            for (int i = 0; i < size; i++)
            {
                sortable.Add(r.Next(-230, 26));
            }

            var algorithm = new GnomeSort<int>();
            algorithm.Sort(sortable);

            Console.WriteLine("Result:");
            foreach (var res in sortable)
            {
                Console.WriteLine(res);
            }
           
            Console.ReadLine();
        }
    }
}
