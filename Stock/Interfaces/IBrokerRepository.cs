using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Models
{
    interface IBrokerRepository
    {
        void AddBroker(Broker b);
        void EditBroker(Broker b);
        void RemoveBroker(int id);
        IEnumerable<Broker> GetBrokers();
        Broker FindBrokerById(int Id);
    }
}
