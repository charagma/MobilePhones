using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MobilePhones.Data
{
    public class Photo
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string FileName { get; set; }

        public int PhoneId { get; set; }

        public virtual Phone Phone { get; set; }
    }
}