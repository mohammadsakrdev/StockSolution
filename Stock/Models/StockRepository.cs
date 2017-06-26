using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Stock.Models
{
    public class StockRepository : IOrderRepository, IBrokerRepository, IPersonRepository, IStockRepository
    {
        StockContext context;

        public StockRepository(StockContext context)
        {
            this.context = context;
        }
        public void AddBroker(Broker b)
        {
            context.Broker.Add(b);
            context.SaveChanges();
        }

        public void AddOrder(Order o)
        {
            context.Order.Add(o);
            context.SaveChanges();
        }

        public void AddPerson(Person p)
        {
            context.Person.Add(p);
            context.SaveChanges();
        }

        public void AddStock(Stock s)
        {
            context.Stock.Add(s);
            context.SaveChanges();
        }

        public void EditBroker(Broker b)
        {
            context.Entry(b).State = EntityState.Modified;
        }

        public void EditOrder(Person p)
        {
            context.Entry(p).State = EntityState.Modified;
        }

        public void EditPerson(Person p)
        {
            context.Entry(p).State = EntityState.Modified;
        }

        public void EditStock(Stock s)
        {
            context.Entry(s).State = EntityState.Modified;
        }

        public Broker FindBrokerById(int Id)
        {
            var result = (from b in context.Broker where b.BrokerID == Id select b).FirstOrDefault();
            return result;
        }

        public Order FindOrderById(int Id)
        {
            var result = (from o in context.Order where o.OrderID == Id select o).FirstOrDefault();
            return result;
        }

        public Person FindPersonById(int Id)
        {
            var result = (from p in context.Person where p.PersonID == Id select p).FirstOrDefault();
            return result;
        }

        public Stock FindStockById(int Id)
        {
            var result = (from s in context.Stock where s.StockID == Id select s).FirstOrDefault();
            return result;
        }

        public IEnumerable<Broker> GetBrokers()
        {
            return context.Broker.ToList();
        }

        public IEnumerable<Order> GetOrders()
        {
            return context.Order.ToList();
        }

        public IEnumerable<Person> GetPersons()
        {
            return context.Person.ToList();
        }

        public IEnumerable<Stock> GetStocks()
        {
            return context.Stock.ToList();
        }

        public void RemoveBroker(int id)
        {
            Broker b = context.Broker.Find(id);
            context.Broker.Remove(b);
            context.SaveChanges();
        }

        public void RemoveOrder(int id)
        {
            Order o = context.Order.Find(id);
            context.Order.Remove(o);
            context.SaveChanges();
        }

        public void RemovePerson(int id)
        {
            Person p = context.Person.Find(id);
            context.Person.Remove(p);
            context.SaveChanges();
        }

        public void RemoveStock(int id)
        {
            Stock s = context.Stock.Find(id);
            context.Stock.Remove(s);
            context.SaveChanges();
        }
    }
}