using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface.Classes;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IFile file = new WordFile();
            WordFile wf = new WordFile();

            file.Load("");
            //file.Save("bye");
            wf.Load("hi");
            wf.Save("gg");
            wf.Delete();

            (file as WordFile).Delete();

            IMailService ims = new MailService();
            MailService ms = new MailService();
            ims.Count = 6;
            ims.SendMail("h");
            ms.SendMail("j");
            ms.Count = 9;

            Console.WriteLine(ims.Count + ms.Count);
            Console.ReadLine();


        }
    }
}
