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
    
        public bool IsSigned { get { return _isSigned; } private set { } }

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





/*Klasa Newsletter będzie posiadać jedną właściwość bool IsSigned.Przypisanie wartości do tej właściwości nie powinno być możliwe.
IsSigned będzie zwracać wartość  prywatnego pola bool _isSigned
Ustawienie tego pola będzie odbywać się poprzez metody void SignIn() oraz void UnSign()
Metody te będa ustawiać true lub false.
*/