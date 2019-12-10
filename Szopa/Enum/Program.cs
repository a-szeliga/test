using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    public enum Software
    {
        Elab,
        Smart,
        Consilio
    }

    public enum Operations
    {
        Addition, Multiplication, Subtraction, Division
    }

    public enum Seasons
        {
        Winter, Spring, Summer, Automn
        }

    class Program
    {    
        static void Main(string[] args)
        {

          
            Software shit = Software.Elab;
            switch (shit)
            {
                case Software.Elab:
                    Console.WriteLine("Elab. Just shit.");
                   break;
                case Software.Smart:
                    Console.WriteLine("Smart. Not so smart.");
                    break;
            }
            Console.ReadLine();

            Operations operations;       
            string result = Console.ReadLine();
            Enum.TryParse(result, out operations);


            switch (operations)
            {
                case Operations.Addition:

                    break;
                case Operations.Subtraction:
                    Console.WriteLine(Operations.Subtraction.ToString());
                    break;
                case Operations.Division:
                    Console.WriteLine(Operations.Division.ToString());
                    break;
                default:
                    break;
            };
          //  Console.WriteLine((int)Operations.Multiplication.ToString());

            //  string result = Console.ReadLine();
            //Seasons result = new season Convert.ToInt32;




        }
    }
}
