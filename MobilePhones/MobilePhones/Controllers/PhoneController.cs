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
        public ActionResult Index(string searchTermPhone, int? searchTermBrand, int? searchTermMinPrice, int? searchTermMaxPrice)
        {
            var model = PhoneRepository.GetPhones(searchTermPhone, searchTermBrand, searchTermMinPrice, searchTermMaxPrice);
            ViewBag.Brands = BrandRepository.GetBrands();
            ViewBag.SearchTermPhone = searchTermPhone;
            ViewBag.SearchTermMinPrice = searchTermMinPrice;
            ViewBag.SearchTermMaxPrice = searchTermMaxPrice;
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