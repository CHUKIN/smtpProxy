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

        public ActionResult Send()
        {
            try
            {
                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("dmitriyatamanchuk@gmail.com", "dima852963?"),
                    EnableSsl = true
                };
                client.Send("dmitriyatamanchuk@gmail.com", "id61899437-02ac7a125@vkmessenger.com", "test", "testbody");
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
            return Content("Sent");
        }
    }
}