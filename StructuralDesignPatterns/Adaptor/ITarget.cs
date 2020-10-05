using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    /// <summary>
    /// Base API that client expects.
    /// Adaptors implement this interface to make the third party API compatible with the ITaget.
    /// </summary>
    public interface ITarget
    {
        List<string> GetEmployees();
    }
}
