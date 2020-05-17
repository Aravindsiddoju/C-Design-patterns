using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //second way of creating singleton class
    //thread safe
    public class InsurancePolicySingletonAppoach2
    {
        private int Id = 123;
        private string Name = "Andrew";
        private static InsurancePolicySingletonAppoach2 _instance = null;
        private static readonly object _lock = new object();
        public InsurancePolicySingletonAppoach2()
        {

        }

        public static InsurancePolicySingletonAppoach2 Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new InsurancePolicySingletonAppoach2();
                    }
                    return _instance;
                }               
            }
            //no setter is required in singleton instance
        }

        public string GetInsuredName()
        {
            return _instance.Name;
        }
    }
}
