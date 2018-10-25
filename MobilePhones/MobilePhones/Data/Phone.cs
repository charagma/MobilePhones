using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MobilePhones.Data
{
    public class Phone
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Dimensions { get; set; }
        public int Weight { get; set; }
        public double ScreenSize { get; set; }
        [StringLength(100)]
        public string Resolution { get; set; }
        [StringLength(100)]
        public string Processor { get; set; }
        [StringLength(100)]
        public string Memory { get; set; }
        [StringLength(100)]
        public string OS { get; set; }
        public int Price { get; set; }
        [StringLength(100)]
        public string Video { get; set; }

        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}