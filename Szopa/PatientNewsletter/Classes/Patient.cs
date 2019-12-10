using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientNewsletter.Classes
{


    public enum PatientType { Regular, New }

    public class Patient 
    {       
        public PatientType PatientType { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public Newsletter Newsletter { get; set; }

        public void Display()
        {
            Console.WriteLine("Pacjent o nazwie: " + Name);
            Console.WriteLine("Posiada adres: " + Address.FullAddress);
            Console.WriteLine("Czy jest zapisany na newsletter: " + Newsletter.IsSigned);
        }

    }
}
/*Napisać klasę Patient która będzie się składać z takich właściwości jak:
PatientType o typie wyliczeniowym - typ wyliczeniowy będzie posiadał dwie wartości Regular i New.
Name o typie string
Adress o typie Adress
Newsletter o typie Newsletter


oraz klasa Patient będzie miała metodę publiczną o nazwie Display(), która wypisze na ekranie dane pacjenta według schematu podanego na zrzucie ekranu.
*/
