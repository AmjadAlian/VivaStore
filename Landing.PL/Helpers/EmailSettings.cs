using Landing.DAL.Models;
using System.Net;
using System.Net.Mail;

namespace Landing.PL.Helpers
{
    public class EmailSettings
    {
        public static void SendEmail(Email email) 
        {
          var client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("amjadalian14@gmail.com", "snwm zwew pzsw iopp");
            client.Send("amjad.alian14@gmail.com",email.Recivers,email.Subject,email.Body);
        }

    }
}
