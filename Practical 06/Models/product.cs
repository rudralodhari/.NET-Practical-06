using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductCatlog.Models
{
    public class product
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int qty { get; set; }
        public int price { get; set; }
        public string imgurl { get; set; }
    }
}