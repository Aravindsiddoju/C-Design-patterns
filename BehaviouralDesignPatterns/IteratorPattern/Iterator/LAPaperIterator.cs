using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Iterator
{
    public class LAPaperIterator : IIterator
    {
        private string[] _reports;
        private int _current;
        public LAPaperIterator(string[] reports)
        {
            this._reports = reports;
            _current = 0;
        }
        public string CurrentItem()
        {
            return this._reports[_current];
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
            return _reports[_current++];
        }
    }
}
