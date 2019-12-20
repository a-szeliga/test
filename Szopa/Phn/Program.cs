using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phn.Models;


namespace Phn
{
    class Program
    {
        static void Main(string[] args)
        {

            GraphicCard graphiteCard1 = new GraphicCard(cores: 4);

            GraphicCard graphiteCard2 = new GraphicCard(cores: 5);

            Processor processor1 = new Processor(structure: "IBM");
            processor1.Speed = 5;

            Processor processor2 = new Processor(structure: "AMD");
            processor2.Speed = 6;

            Phone phone1 = new Phone();
            phone1.Processor = processor1;
            phone1.GraphicCard = graphiteCard1;

            Phone phone2 = new Phone();
            phone2.Processor = processor2;
            phone2.GraphicCard = graphiteCard2;

            Console.WriteLine("Telefon1");
            //Console.WriteLine(phone1.GetGraphicCard.Cores();) - if protected
            Console.WriteLine(phone1.GraphicCard.Cores);
            Console.WriteLine(phone1.Processor.Speed);
            Console.WriteLine(phone1.Processor.Structure);

            Console.WriteLine("Telefon2");
            Console.WriteLine(phone2.GraphicCard.Cores);
            Console.WriteLine(phone2.Processor.Speed);
            Console.WriteLine(phone2.Processor.Structure);

            Console.ReadLine();
        }
    }
}
