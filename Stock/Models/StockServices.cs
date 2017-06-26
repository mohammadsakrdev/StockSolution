using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Stock.Models
{
    public class StockServices
    {
        public StockRepository db;

        public StockServices(StockContext context)
        {
            db = new StockRepository(context);
        }
        public  void UpdateStocks()
        {
            Random rnd = new Random();
            foreach (var item in db.GetStocks())
            {
                item.Price = rnd.Next(1, 100);
                db.EditStock(item);
            }
        } // end method UpdateStocks

        public void InsertOrders()
        {
            for (int i = 0; i < 10; i++)
            {   
                CreateOrder();
            }

        }

        private void CreateOrder()
        {
            Order order = new Order
            {
                StockID = new Random().Next(1, 28),
            Quantity =  new Random().Next(1, 10)
        };
            order.Price = db.FindStockById(order.StockID).Price * order.Quantity;
            bool x = new Random().Next(1, 10) > 5 ? false : true;
            if (x)
            {
                order.Broker = db.FindBrokerById(1);
                order.Person = db.FindPersonById(1);
                order.Commission = (decimal)0.01d;
            }
            else
            {
                order.Broker = db.FindBrokerById(1);
                order.Person = db.FindPersonById(2);
                order.Commission = (decimal)0.02;
            }
            db.AddOrder(order);
        } // end method CreateOrder

        private int GetRandomStock()
        {
            return new Random().Next(1, 28);
        }

        private int GetRandomQuantity()
        {
            return new Random().Next(1, 10);
        }


    } // end class StockServices
}