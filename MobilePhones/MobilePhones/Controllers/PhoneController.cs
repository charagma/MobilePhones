using MobilePhones.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobilePhones.Controllers
{
    public class PhoneController : Controller
    {
        public ActionResult Index()
        {
            var model = PhoneRepository.GetPhones();
            return View(model);
        }

        public ActionResult Specs(int id)
        {
            var model = PhoneRepository.GetPhone(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }
    }
}