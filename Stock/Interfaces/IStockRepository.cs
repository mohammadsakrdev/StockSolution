using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Models
{
    interface IStockRepository
    {
        void AddStock(Stock s);
        void EditStock(Stock s);
        void RemoveStock(int Id);
        IEnumerable<Stock> GetStocks();
        Stock FindStockById(int Id);
    }
}

