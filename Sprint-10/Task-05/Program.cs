using System;

namespace Task_05
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
        INotification notification;
        public Customer(INotification notification)
        {
            this.notification = notification;
        }

        public void Register(string email, string passpord)
        {            
            try
            {
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SendNotification(INotification notification) 
        {
            notification.SendNotification();
        }
    }
    public interface INotification
    {
        void SendNotification();
    }
    public interface INotificationToDB
    {
        void AddNotificationToDB();
    }
    public interface INotificationToDBRead
    {
        void ReadNotification();
    }
    class MailService : INotificationToDB, INotification, INotificationToDBRead
    {
        public string Email { get; set; }
        public string EmailTitle { get; set; }
        public string EmailBody { get; set; }
        public bool ValidEmail()
        {
            return Email.Contains("@");
        }

        public void SendNotification()
        {
            Console.WriteLine(string.Format("Mail:{0}, Title:{1}, Body:{2}",
                Email, EmailTitle, EmailBody));
        }

        public void AddNotificationToDB()
        {

        }

        public void ReadNotification()
        {

        }
    }

    class SmsService : INotification
    {
        public string Number { get; set; }
        public string SmsText { get; set; }
        public void SendNotification()
        {
            Console.WriteLine(string.Format("Number:{0}, Message:{1}", Number, SmsText));
        }
    }
}
