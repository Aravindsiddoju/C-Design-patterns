using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPattern.Iterator;

namespace IteratorPattern.Aggregate
{
    public class NYPaper : INewspaper
    {
        private int[] _reports;
        public NYPaper()
        {
            _reports = new int[] {
                5,
                10
            };
        }
        public IIterator CreateIterator()
        {
            return new NYPaperIterator(_reports);
        }
    }
}
