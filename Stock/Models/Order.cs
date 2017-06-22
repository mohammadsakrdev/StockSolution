using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stock.Models
{
    [Bind(Exclude = "StockID")]
    public class Order
    {
        [Key]
        [ScaffoldColumn(false)]
        public int OrderID { get; set; }
        public int StockID { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [DisplayName("Price")]
        public double Price { get; set;}
        [DisplayName("Quantity")]
        [Required(ErrorMessage ="Quantity is mandatory")]
        public int Quantity { get; set; }
        [DisplayName("Commission")]
        [Range(0.00, 1.00, ErrorMessage = "Commission must be between 0.00 and 1.00")]
        public decimal Commission { get; set; }

        //Navigation
        public virtual Person Person { get; set; }
        public virtual Broker Broker { get; set; }
        public virtual Stock Stock { get; set; }
    } // end class Order
}