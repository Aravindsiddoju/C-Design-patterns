using IteratorPattern.Aggregate;
using IteratorPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Aggregate
{
    public class LAPaper : INewspaper
    {
        private string[] _reports;
        public LAPaper()
        {
            _reports = new string[] {
                "Aravind Siddoju - LA",
                "Davinci - LA"
            };
        }
        public IIterator CreateIterator()
        {
            return new LAPaperIterator(_reports);
        }
    }
}
