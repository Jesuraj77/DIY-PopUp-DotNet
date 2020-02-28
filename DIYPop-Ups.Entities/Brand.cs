using System;
using System.Collections.Generic;
using System.Text;

namespace DIYPop_Ups.Entities
{
    public class Brand
    {
        public int Id{ get; set; }
        public string BrandName { get; set; }
        public string BrandDescription { get; set; }
        public int AdvertiserId { get; set; }
        public  string Video { get; set; }

    }
}
