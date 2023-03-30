using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pass_Session_MVC.Models
{
    public class ProductModel
    {
        
        public string area { get; set; }

        public string branch { get; set; }
        public string datepick { get; set; }
        public string edatepick { get; set; }
        [Required]
        public   string quantity { get; set; }
        public string productname { get; set; }
        public string silo { get; set; }
       
        public string notes { get; set; }

        public string timer1 { get; set; }
        public string timer2 { get; set; }

    }

}