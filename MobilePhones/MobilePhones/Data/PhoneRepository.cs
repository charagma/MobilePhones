using MobilePhones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MobilePhones.Data
{
    public class PhoneRepository
    {
        public static List<Phone> GetPhones()
        {
            try
            {
                using (var db = new MobilePhonesContext())
                {
                    var phones = db.Phones.Include(p => p.Photos).OrderByDescending(p => p.Id).ToList();
                    return phones;
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