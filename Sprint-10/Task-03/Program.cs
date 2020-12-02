﻿using System;

namespace Task_03
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
        public static void Register(string email, string passpord)
        {
            MailService mailService = new MailService() { Email = email, EmailTitle = "User registration", EmailBody = "Body of message..." };
            SmsService smsService = new SmsService() { Number = "111 111 111", SmsText = "User successfully registered..." };
            try
            {
                if (mailService.ValidEmail())
                {
                    mailService.SendNotification();
                    mailService.AddNotificationToDB();
                    smsService.SendNotification();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
    public interface INotification
    {
        public void SendNotification();
    }
    public interface INotificationToDB
    {
        public void AddNotificationToDB();
    }
    class MailService : INotificationToDB, INotification
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
