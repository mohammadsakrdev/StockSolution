using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Models
{
    interface IOrderRepository
    {
        void AddOrder(Order o);
        void EditOrder(Person p);
        void RemoveOrder(int id);
        IEnumerable<Order> GetOrders();
        Order FindOrderById(int Id);
    }
}
