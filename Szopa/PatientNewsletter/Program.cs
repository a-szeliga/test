using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientNewsletter.Classes;

namespace PatientNewsletter
{
    class Program
    {
        static void Main(string[] args)
        {

            // Patient.PatientType patientType1 = Patient.PatientType.Regular;
            //Patient.PatientType patientType2 = Patient.PatientType.New;

            Patient p1 = new Patient();
            p1.PatientType = PatientType.Regular;          
            p1.Name = "Łukasz W";
            p1.Address = new Address() { FullAddress = "Bukowno,"+ "Starczynowska" };
            p1.Newsletter = new Newsletter() { IsSigned = true };
          

            Patient p2 = new Patient();
            p2.PatientType = PatientType.Regular;
            p2.Name = "Tomek W";
            p2.Address = new Address() { FullAddress = "Kraków, Focha" };
            p2.Newsletter = new Newsletter() { IsSigned = false };


            Patient p3 = new Patient();
            p3.PatientType = PatientType.New;
            p3.Name = "Krzysiek W";
            p3.Address = new Address() {FullAddress = "Kraków, Focha"};
            p3.Newsletter = new Newsletter() { IsSigned = true };
            



            Patient[] patients = new Patient[3];
            patients[0] = p1;
            patients[1] = p2;
            patients[2] = p3;

            for (int i = 0; i<patients.Length; i++)
            {
                patients[i].Newsletter.SignIn();
                patients[i].Display();
            }

            for (int i = 0; i < patients.Length; i++)
            {
                patients[i].Newsletter.UnSign();
                patients[i].Display();
            }

            for (int i = 0; i < patients.Length; i++)
            {
                if (patients[i].PatientType == PatientType.Regular)
                 { patients[i].Newsletter.SignIn(); }

                patients[i].Display();
            }
            Console.ReadLine();
        }
    }
}
/*
W klasie głównej programu:
Utworzyć trzy obiekty pacjenta
Nadać każdemu pacjentowi nazwę
Pierwszemu ustawić PatientType na Regular
Drugiemu ustawić PatientType na Regular
Trzeciemu ustawić PatientType na New
Nadać wszystkim pacjentom adress składający się z miasta i ulicy.

Dodać pacjentów do tablicy.
Następnie wykonać pętlę która zapisze wszystkich pacjentów do newslettera i wypisze ich wszystkie dane za pomocą metody Display().
Następnie wykonać pętlę która wypisze wszystkich pacjentów z newslettera i wypisze ich wszystkie dane za pomocą metody Display().
Następnie wykonać pętlę która zapisze wszystkich pacjentów do newslettera którzy są stałymi klientami i wypisze ich wszystkie dane za pomocą metody Display().

Zrzut ekranu jak powinien wyglądać program na slajdzie 60.
*/