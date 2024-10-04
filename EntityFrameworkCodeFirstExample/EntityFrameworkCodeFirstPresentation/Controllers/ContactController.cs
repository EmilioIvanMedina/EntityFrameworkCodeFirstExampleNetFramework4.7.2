using EntityFrameworkCodeFirstPresentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkCodeFirstPresentation.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            var model = new ContactMessageViewModel();
            ViewBag.Message = "Your contact page.";
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(ContactMessageViewModel model)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Message = "Your message has been sent!";
            }

            return View(model);
        }
    }
}