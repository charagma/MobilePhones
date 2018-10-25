using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MobilePhones.Data
{
    public class Brand
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }
    }
}