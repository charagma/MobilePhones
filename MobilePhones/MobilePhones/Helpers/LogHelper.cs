using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace MobilePhones.Helpers
{
    public class LogHelper
    {
        public static void LogError(Exception e)
        {
            File.AppendAllText(HttpContext.Current.Server.MapPath(@"\App_Data\Errors.txt"), e.Message + "\n\n");
        }
    }
}