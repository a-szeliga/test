using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientNewsletter.Classes
{
    
    public class Newsletter
    {
        //Przypisanie wartości do tej właściwości nie powinno być możliwe.

        private bool _isSigned;
    
        public bool IsSigned { get { return _isSigned; }  }

        public void SignIn()
        {
            _isSigned = true;
        }

        public void UnSign()
        {
            _isSigned = false;
        }
    }
}
