using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Iterator
{
    public interface IIterator
    {
        // sets the current element to the first element
        void First();

        // Advances current element to the next element
        string Next();

        //check if end of the collection
        bool IsDone();

        // returns the current element
        string CurrentItem();
    }
}
