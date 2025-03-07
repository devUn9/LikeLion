using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExam2
{
    interface IPayment
    {
        void ProcessPayment();
    }

    class CreditCardPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("신용카드 결제 완료!");
        }
    }
    class paymentProcessor
    {
        public void Pay(IPayment payment)
        {
            payment.ProcessPayment();
        }
    }

    class PayPalPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("PayPal 결제 완료!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            paymentProcessor processor = new paymentProcessor();

            IPayment creditCard = new CreditCardPayment();
            IPayment paypal = new PayPalPayment();

            processor.Pay(creditCard);
            processor.Pay(paypal);
        }
    }
}
