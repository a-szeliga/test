using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.Classes
{
    public class File
    {
        public string Name { get; set; }
        public int Size { get; set; }

        public void Delete()
        {
            Console.WriteLine("Delete" + Name);
        }

    }

    public class GenericFile<T>
    {


        public void Display()
        {
            Console.WriteLine("Displaying..");
        }
    }

    public class GenericFileList<T> 
    {
        public void Add()
        {
            Console.WriteLine("adding..");
        }

    }



}

