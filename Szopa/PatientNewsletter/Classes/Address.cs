using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientNewsletter.Classes
{
    public class Address
    {



        public string FullAddress { get; set; }
        // public string FullAddress { get { return fullAddress; } set { } }


        private void PrepareAddress(string _city, string _street)
        {
      
        // fullAddress = _city + _street;
            
        }
    
        
        
     
    }
}            
    

/*
Klasa Adress będzie składać się z jednej właściwości FullAdress.
Właściwość tą będzie ustawiać tylko i wyłącznie prywatna metoda PrepareAdress(), nie ma być możliwości ustawiania tej właściwości z zewnątrz.
Metoda PrepareAdress będzie wywołana w konstruktorze i będzie sklejać prywatne pola _city + _street i przypisywać do FullAdress.
*/
  