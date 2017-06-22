using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stock.Models
{
    [Bind(Exclude = "BrokerID")]
    public class Broker
    {
        [Key]
        [ScaffoldColumn(false)]
        public int BrokerID { get; set; }
        [DisplayName("Broker Name")]
        [Required(ErrorMessage = "Name is mandatory")]
        [StringLength(160)]
        public string Name { get; set; }

        //navigations
        public virtual  List<Person> Persons { get; set; }
        public virtual List<Order> Orders { get; set; }
    } // end class Broker
}