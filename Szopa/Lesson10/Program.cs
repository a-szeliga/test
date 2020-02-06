using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson10.Classes;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {

            //exceptions
            try
            {
                int y = 0;
                int x = 10 / y;
                throw new NullReferenceException("ss");
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }

            catch (IndexOutOfRangeException exception)
            {
                throw;
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Błąd");
            }

            //Lists 
            File file1 = new File();
            File file2 = new File();
            File file3 = new File();
            File file4 = new File();

            List<File> fileList = new List<File>();
            fileList.Add(file1);
            fileList.Add(file2);
            fileList.Add(file3);
            fileList.Add(file4);
            fileList.Count();
            //fileList.Sort();

            foreach (File file in fileList)
            {
                file.Delete();
            }

            //klasy generyczne

            GenericFile<int> iGenericFile = new GenericFile<int>();
            GenericFile<string> sGenericFile = new GenericFile<string>();
            iGenericFile.Display();
            sGenericFile.Display();
            

            GenericFileList<int> iGenericFileList = new GenericFileList<int>();
            GenericFileList<string> sGenericFileList = new GenericFileList<string>();
           
            sGenericFileList.Add();
            iGenericFileList.Add();

            Console.ReadLine();
        }
    }
}
