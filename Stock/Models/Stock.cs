using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Stock.Models
{
    public class Stock
    {
        [ScaffoldColumn(false)]
        public int StockID { get; set; }
        [DisplayName("Item Name")]
        public string Name { get; set; }
        [DisplayName("Price")]
        public double Price { get; set; }
    }
}