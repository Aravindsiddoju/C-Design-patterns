using IteratorPattern.Aggregate;
using IteratorPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            INewspaper nyt = new NYPaper();
            INewspaper lat = new LAPaper();

            IIterator nytIterator = nyt.CreateIterator();
            IIterator latIterator = lat.CreateIterator();

            Console.WriteLine("-----------     NY Paper");
            PrintReports(nytIterator);

            Console.WriteLine("-----------     LA Paper");
            PrintReports(latIterator);
        }

        private static void PrintReports(IIterator iterator)
        {
            iterator.First();
            while(!iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
