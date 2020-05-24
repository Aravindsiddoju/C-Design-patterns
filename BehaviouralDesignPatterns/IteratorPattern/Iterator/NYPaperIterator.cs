using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Iterator
{
    public class NYPaperIterator : IIterator
    {
        private int[] _reports;
        private int _current;
        public NYPaperIterator(int [] reports)
        {
            _reports = reports;
            _current = 0;
        }
        public string CurrentItem()
        {
            return _reports[_current].ToString();
        }

        public void First()
        {
            _current = 0;
        }

        public bool IsDone()
        {
            return _current >= _reports.Length;
        }

        public string Next()
        {
            return _reports[_current++].ToString();
        }
    }
}
