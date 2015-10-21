using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int size = r.Next(100, 100);
            var sortable = new List<int>();
            Stopwatch timer = new Stopwatch();

            for (int i = 0; i < size; i++)
            {
                sortable.Add(r.Next(-230, 26));
            }

            var algorithm = new GnomeSort<int>();

            timer.Start();
            algorithm.Sort(sortable);
            timer.Stop();
            
            TimeSpan time = timer.Elapsed;

            string elapsedTime = String.Format("{0:00}.{1:00}", time.Seconds, time.Milliseconds / 10);

            Console.WriteLine("GnomeSort runtime = " + elapsedTime + "\n");

            Console.WriteLine("Result:");
            foreach (var res in sortable)
            {
                Console.WriteLine(res);
            }

            Console.ReadLine();
        }
    }
}
