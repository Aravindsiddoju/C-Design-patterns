using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //third way to create singleton class
    // thread safe
    public class InsurancePolicySingletonAppoach3
    {
        private int Id = 123;
        private string Name = "Andrew";
        private static readonly InsurancePolicySingletonAppoach3 _instance = new InsurancePolicySingletonAppoach3();
        public InsurancePolicySingletonAppoach3()
        {

        }

        public static InsurancePolicySingletonAppoach3 Instance
        {
            get
            {
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
