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
            Console.WriteLine("Czy jest zapisany na newsletter: " + (Newsletter.IsSigned ? "tak" : "nie"));
            Console.WriteLine();
        }

    }
}