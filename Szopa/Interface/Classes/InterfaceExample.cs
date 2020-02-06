using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Classes
{
    public interface IMailService
    {
        int Count{get;set;}
        void SendMail(string Content);

        string GetMailMessage();
    }

    public class MailService : IMailService
    {

        private string _mail;
        public int Count { get; set; }


        public void SendMail(string content)
        {
            _mail = content;

        }
        public string GetMailMessage()
        {
            return _mail;
        }


    }
}
