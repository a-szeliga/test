using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Classes
{
    public interface IFile
    {
        void Save(string fileName);

        string Load(string fileName);
    }

    public class File
    {
        public virtual void Delete()
        {
            Console.WriteLine("Plik usunięty.");
        }        
    }

    public class WordFile : File, IFile
    {

        public string Load(string fileName)
        {
            return fileName;
        }
        public void Save(string fileName)
        {
            Console.WriteLine("xss");
        }

        
    }
}
