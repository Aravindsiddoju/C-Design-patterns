using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momento
{
    public class CareTaker
    {
        //Where all the momentos are saved.
        List<Momento> savedStatements = new List<Momento>();

        public void AddMomento(Momento m)
        {
            savedStatements.Add(m);
        }

        public Momento GetMomento(int index)
        {
            if(index < -1)
            {
                return new Momento(string.Empty);
            }
            else
            {
                return savedStatements[index];
            }
        }
    }
}
