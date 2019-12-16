using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientNewsletter.Classes
{
    public class Address
    {
        private string _city;
        private string _street;

        public string FullAddress { get; private set; }       

        public Address(string city, string street)
        {
            _city = city;
            _street = street;
            PrepareAddress();
        }

        private void PrepareAddress()
        {            
            FullAddress = _city + _street;            
        }             
    }
}            