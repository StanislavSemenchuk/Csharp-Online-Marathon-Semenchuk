using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Customer 
    {
        public void Register(string email, string passpord) 
        {
            MailService mailService = new MailService();
            try
            {
                if (mailService.ValidEmail(email)) 
                {
                    mailService.SendEmail(email, "Email title", "Email body");
                }
            }
            catch (Exception ex) 
            {
                throw;
            }
        }
    }
    class MailService
    {
        public bool ValidEmail(string Email) 
        {
            return Email.Contains("@");
        }

        public void SendEmail(string mail, string emailTitle, string emailBody) 
        {
            Console.WriteLine(string.Format("Mail: {0}, Title: {1}, Body: {2}",
                mail, emailTitle, emailBody));
        }
    }
}
