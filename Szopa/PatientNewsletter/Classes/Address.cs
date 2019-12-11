using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientNewsletter.Classes
{
    public class Address
    {
        public string FullAddress { get; private set; }       

        public Address(string _city, string _street)
        {
            PrepareAddress(_city, _street);
        }

        private void PrepareAddress(string city, string street)
        {            
            FullAddress = city + street;            
        }             
    }
}            