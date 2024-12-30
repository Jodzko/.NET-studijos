using System.Net;
using System.Net.Mail;
using System.Text;

namespace Projektas_Restoranas
{
    public class MailSendingService : ISender
    {

        public void SendCustomerReceipt(Order order, Waiter waiter)
        {
            using SmtpClient smtp = new SmtpClient
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Host = "smtp.office365.com",
                Port = 587,

                Credentials = new NetworkCredential("artur.jodzko@codeacademylt.onmicrosoft.com", "Enter password Here"),

            };
            string subject = "Your receipt";
            string receipt = PrintingService.PrintCustomerReceipt(order, waiter);
            
            try
            {
                Console.WriteLine("Sending email....");
                smtp.Send("artur.jodzko@codeacademylt.onmicrosoft.com", "artur.jodzko@codeacademylt.onmicrosoft.com", subject, receipt);
                Console.WriteLine("Email sent successfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public void SendRestaurantReceipt(Order order, Waiter waiter)
        {
            using SmtpClient smtp = new SmtpClient
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Host = "smtp.office365.com",
                Port = 587,

                Credentials = new NetworkCredential("artur.jodzko@codeacademylt.onmicrosoft.com", "Enter password Here"),

            };
            string subject = $"Restaurant receipt, order number {order.UniqueSerialNumber}";
            string restaurantReceipt = PrintingService.PrintRestaurantReceipt(order, waiter);
            try
            {
                Console.WriteLine("Sending email....");
                smtp.Send("artur.jodzko@codeacademylt.onmicrosoft.com", "artur.jodzko@codeacademylt.onmicrosoft.com", subject, restaurantReceipt);
                Console.WriteLine("Email sent successfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
