using BusinessLayer.Conrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSon.Controllers
{
    [AllowAnonymous]
    public class MailSubscribeController : Controller
    {
        [HttpGet]
        public PartialViewResult AddMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddMail(SubscribeMail p)
        {
            SubscribeMailManager sm= new SubscribeMailManager();
            sm.BLAdd(p);
            return PartialView();
        }
    }
}