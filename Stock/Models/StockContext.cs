using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Stock.Models
{
    public class StockContext:DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Broker> Broker { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Stock> Stock { get; set; }
    } // end class StockContext
}