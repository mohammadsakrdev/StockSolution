using Stock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stock.Controllers
{
    public class HomeController : Controller
    {
        private StockContext stockDB = new StockContext();
        
        public ActionResult Index()
        {
            StockServices service = new StockServices();
            service.UpdateStocks();
            if (Request.IsAjaxRequest())
            {
                return PartialView("StockList",stockDB.Stock);
            }

            return View(stockDB.Stock);
        }

        public ActionResult Orders()
        {
            StockServices service = new StockServices();

            service.InsertOrders();

            var orders = stockDB.Order;

            if (Request.IsAjaxRequest())
            {
           
                return PartialView("OrdersList", orders);
            }
            return View(orders);
        }
    }
}