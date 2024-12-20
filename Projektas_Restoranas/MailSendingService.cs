using System.Net.Mail;
namespace Projektas_Restoranas
{
    public class MailSendingService
    {
        public static void SendingEmail(Order order)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("testingforstudies3255@gmail.com");
                mail.To.Add("testingforstudies3255@gmail.com");
                mail.Subject = "Your Receipt";
                mail.Body = order.Receipt.ToString();

                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("testingforstudies3255@gmail.com", "Slaptazodis1");
                smtp.EnableSsl = true;

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
