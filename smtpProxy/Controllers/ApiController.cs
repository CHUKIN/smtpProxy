using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace smtpProxy.Controllers
{
    public class ApiController : Controller
    {
        // GET: Api
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Send(string to,string subject, string message)
        {
            try
            {
                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("dmitriyatamanchuk@gmail.com", "dima852963?"),
                    EnableSsl = true
                };
                MailMessage mail = new MailMessage("dmitriyatamanchuk@gmail.com", to, subject, message);
                mail.IsBodyHtml = true;
                client.Send(mail);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
            return Content("Sent");
        }
    }
}


//"id61899437-02ac7a125@vkmessenger.com"