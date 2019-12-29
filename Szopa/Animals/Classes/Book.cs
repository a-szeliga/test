using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Classes
{
    public abstract class Book
    {
        public int Page { get; set; }
        public virtual bool Cover {get;set;}
        public virtual string Title { get; set; }

        public abstract void Read();
        public void Buy()
        {
            Console.WriteLine("Kup: " + Title);
        }
       

    }

    public class ProfessionalBook : Book
    {
        public override bool Cover { get => base.Cover; set => base.Cover = value; }

        public override string Title { get => base.Title; set => base.Title = value; }
        public override void Read()
        {
            Console.WriteLine("Przeczytaj "+ Title + " wszystkie strony: " + Page);
            base.Buy();

        }
    }
}
