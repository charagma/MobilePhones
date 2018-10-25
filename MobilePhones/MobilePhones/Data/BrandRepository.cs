using MobilePhones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobilePhones.Data
{
    public class BrandRepository
    {
        public static List<Brand> GetBrands()
        {
            try
            {
                using (var db = new MobilePhonesContext())
                {
                    return db.Brands.ToList();
                }
            }
            catch (Exception e)
            {
                LogHelper.LogError(e);
                return new List<Brand>();
            }
        }
    }
}