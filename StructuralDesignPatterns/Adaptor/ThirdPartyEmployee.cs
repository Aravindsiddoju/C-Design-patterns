using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    public class ThirdPartyEmployee
    {
        public Dictionary<string, int> GetEmployeeList()
        {
            return new Dictionary<string, int>
            {
                { "Adam Girlchrist", 1},
                { "Yuvraj Singh", 2 },
                { "Roger Federer", 3 },
                { "Novak djakovic", 4 }
            };
        }
    }
}
