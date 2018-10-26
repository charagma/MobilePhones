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
        public ActionResult Index(int? activePage, string searchTermPhone, int? searchTermBrand, int? searchTermMinPrice, int? searchTermMaxPrice)
        {
            if (activePage == null || activePage <= 0)
            {
                activePage = 1;
            }
            var model = PhoneRepository.GetPhones(activePage.Value, searchTermPhone, searchTermBrand, searchTermMinPrice, searchTermMaxPrice);
            ViewBag.Brands = BrandRepository.GetBrands();
            ViewBag.SearchTermPhone = searchTermPhone;
            ViewBag.SearchTermBrand = searchTermBrand;
            ViewBag.SearchTermMinPrice = searchTermMinPrice;
            ViewBag.SearchTermMaxPrice = searchTermMaxPrice;
            ViewBag.ActivePage = activePage.Value;
            ViewBag.PageCount = PhoneRepository.GetPageCount(searchTermPhone, searchTermBrand, searchTermMinPrice, searchTermMaxPrice);

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