using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Stock.Models
{
    public class StockServices
    {
        StockContext db = new StockContext();
        public  void UpdateStocks()
        {
            Random rnd = new Random();
            foreach (var item in db.Stock.ToList())
            {
                item.Price = rnd.Next(1, 100);
                db.Entry(item).State = EntityState.Modified;
            }
            db.SaveChanges();
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
            order.Price = db.Stock.Find(order.StockID).Price * order.Quantity;
            bool x = new Random().Next(1, 10) > 5 ? false : true;
            if (x)
            {
                order.Broker = db.Broker.Find(1);
                order.Person = db.Person.Find(1);
                order.Commission = (decimal)0.01d;
            }
            else
            {
                order.Broker = db.Broker.Find(1);
                order.Person = db.Person.Find(2);
                order.Commission = (decimal)0.02;
            }
            db.Order.Add(order);
            db.SaveChanges();
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