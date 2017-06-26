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
        private static StockServices service;
        public HomeController()
        {
            service = new StockServices(new StockContext());
        }
        
        public ActionResult Index()
        {
            
            service.UpdateStocks();
            if (Request.IsAjaxRequest())
            {
                return PartialView("StockList",service.db.GetStocks());
            }

            return View(service.db.GetStocks());
        }

        public ActionResult Orders()
        {

            service.InsertOrders();

            var orders = service.db.GetOrders();

            if (Request.IsAjaxRequest())
            {
           
                return PartialView("OrdersList", orders);
            }
            return View(orders);
        }
    }
}