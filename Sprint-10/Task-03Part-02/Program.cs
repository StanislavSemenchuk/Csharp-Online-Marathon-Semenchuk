using System;

namespace Task_03Part_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public enum InvoiceType
    {
        Final,
        Proposed
    };
    //class Invoice
    //{
    //    public InvoiceType InvoiceType { get; set; }
    //    public double GetDiscount(double amount, InvoiceType invoiceType)
    //    {
    //        double finalAmount = 0;
    //        if (invoiceType == InvoiceType.Final)
    //        {
    //            finalAmount = amount - amount * 0.03;
    //        }
    //        else if (invoiceType == InvoiceType.Proposed)
    //        {
    //            finalAmount = amount - amount * 0.05;
    //        }

    //        return finalAmount;
    //    }
    //}

    public abstract class Invoice 
    {
        public abstract double GetDiscount(double amount);
    }

    public class FinalInvoice : Invoice
    {
        public override double GetDiscount(double amount)
        {
            double finalAmount = 0;
            finalAmount = amount - amount * 0.03;
            return finalAmount;
        }
    }
    public class ProposedInvoice : Invoice
    {
        public override double GetDiscount(double amount)
        {
            double finalAmount = 0;
            finalAmount = amount - amount * 0.05;
            return finalAmount;
        }
    }
    public class RecurringInvoice : Invoice
    {
        public override double GetDiscount(double amount)
        {
            double finalAmount = 0;
            finalAmount = amount - amount * 0.1;
            return finalAmount;
        }
    }

    public class OrdinaryInvoice : Invoice
    {
        public override double GetDiscount(double amount)
        {
            double finalAmount = 0;
            finalAmount = amount - amount * 0.01;
            return finalAmount;
        }
    }
}
