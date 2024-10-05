using CustomerMessageApplication.DTOs;
using CustomerMessageApplication.Interfaces;
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
        private readonly ICustomerMessageRepository _customerMessageRepository;

        public ContactController(ICustomerMessageRepository customerMessageRepository)
        {
            _customerMessageRepository = customerMessageRepository;
        }

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
                var message = new CustomerMessageDTO
                {
                    Email = model.Email,
                    Message = model.Message,
                    Name = model.Name
                };

                _customerMessageRepository.SaveMesssage(message);

                model = new ContactMessageViewModel();

                ViewBag.Message = "Your message has been sent!";
            }

            return View(model);
        }
    }
}