using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //Raw method to create singleton class
    //not thread safe
    public class InsurancePolicySingletonApproach1
    {
        private int Id = 123;
        private string Name = "Andrew";
        private static InsurancePolicySingletonApproach1 _instance = null;
        public InsurancePolicySingletonApproach1()
        {

        }

        public static InsurancePolicySingletonApproach1 Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new InsurancePolicySingletonApproach1();
                }
                return _instance;
            }
            //no setter is required in singleton instance
        }

        public string GetInsuredName()
        {
            return _instance.Name;
        }

    }
}
