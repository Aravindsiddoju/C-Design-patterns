using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    /// <summary>
    /// The adaptor class for the adaptee "ThirdPartyEmployee".
    /// This class takes care of making the third party API compatible with client API "ITarget".
    /// It inherits from ThirdPartyEmployee and also implements the ITarget interface to provide the data in the expected manner to the client.
    /// Every third party customer will have its adaptor as a child, that can make the API compatible with the client API.
    /// Client never calls the third party employee API directly since they don't the API.
    /// They call the pertaining adaptor to get the data from the third party employee.
    /// </summary>
    public class EmployeeAdaptor : ThirdPartyEmployee, ITarget
    {
        public List<string> GetEmployees()
        {
            var employeesDictionary = GetEmployeeList();
            List<string> employeesAsList = employeesDictionary.Keys.ToList();
            return employeesAsList;
        }
    }
}
