using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stock.Models
{
    [Bind(Exclude = "PersonID")]
    public class Person
    {
        [Key]
        [ScaffoldColumn(false)]
        public int PersonID { get; set; }
        [Required(ErrorMessage ="Name is mandatory")]
        [DisplayName("Customer Name")]
        [StringLength(160)]
        public string Name { get; set; }

        //navigations
        public virtual List<Order> Orders { get; set; }
    } // end class Broker
}