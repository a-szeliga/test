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

            Patient p1 = new Patient();
            p1.PatientType = PatientType.Regular;          
            p1.Name = "Łukasz W";
            //p1.Address = new Address() { FullAddress = "Bukowno,"+ "Starczynowska" };
            //p1.Address = new Address() { FullAddress = "Bukowno, Starczynowska" };
             p1.Address = new Address("Bukowno, ", "Starczynowska");
            //p1.Newsletter = new Newsletter() { IsSigned = true };
            p1.Newsletter = new Newsletter();


            Patient p2 = new Patient();
            p2.PatientType = PatientType.Regular;
            p2.Name = "Tomek W";
            p2.Address = new Address("Kraków, ", "Focha");
            p2.Newsletter = new Newsletter();
            //p2.Newsletter.IsSigned = true;
            Patient p3 = new Patient();
            p3.PatientType = PatientType.New;
            p3.Name = "Krzysiek W";
            p3.Address = new Address("Kraków.", "Focha");
            p3.Newsletter = new Newsletter();

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