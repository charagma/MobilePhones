﻿using MobilePhones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MobilePhones.Data
{
    public class PhoneRepository
    {
        private static IQueryable<Phone> GetPhoneQuery(MobilePhonesContext db, string searchTermPhone, int? searchTermBrand, int? searchTermMinPrice, int? searchTermMaxPrice)
        {
            IQueryable<Phone> query = db.Phones;

            if (searchTermPhone != null)
            {
                query = query.Where(p => p.Name.Contains(searchTermPhone));
            }
            if (searchTermBrand != null)
            {
                query = query.Where(p => p.BrandId == searchTermBrand);
            }
            if (searchTermMinPrice != null)
            {
                query = query.Where(p => p.Price >= searchTermMinPrice);
            }
            if (searchTermMaxPrice != null)
            {
                query = query.Where(p => p.Price <= searchTermMaxPrice);
            }

            return query;
        }

        public static double GetPageCount(string searchTermPhone, int? searchTermBrand, int? searchTermMinPrice, int? searchTermMaxPrice)
        {
            try
            {
                using (var db = new MobilePhonesContext())
                {
                    var query = GetPhoneQuery(db, searchTermPhone, searchTermBrand, searchTermMinPrice, searchTermMaxPrice);
                    return Math.Ceiling(1.0 * query.Count() / 6);
                }
            }
            catch (Exception e)
            {
                LogHelper.LogError(e);
                return 1;
            }
        }

        public static List<Phone> GetPhones(int activePage, string searchTermPhone, int? searchTermBrand, int? searchTermMinPrice, int? searchTermMaxPrice)
        {
            try
            {
                using (var db = new MobilePhonesContext())
                {
                    var query = GetPhoneQuery(db, searchTermPhone, searchTermBrand, searchTermMinPrice, searchTermMaxPrice);
                    return query.Include(p => p.Photos).OrderByDescending(p => p.Id).Skip(6*(activePage-1)).Take(6).ToList();
                }
            }
            catch (Exception e)
            {
                LogHelper.LogError(e);
                return new List<Phone>();
            }
        }

        public static Phone GetPhone(int id)
        {
            try
            {
                using (var db = new MobilePhonesContext())
                {
                    return db.Phones.Include(p => p.Photos).Include(p => p.Brand).FirstOrDefault(p => p.Id == id);
                }
            }
            catch (Exception e)
            {
                LogHelper.LogError(e);
                return null;
            }
        }
    }
}