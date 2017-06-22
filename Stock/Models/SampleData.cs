using Stock.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Stock.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<StockContext>
    {
        protected override void Seed(StockContext context)
        {
            new List<Stock>
            {
                            new Stock {StockID= 1, Name= "Vianet" },
                            new Stock {StockID=2, Name = "Agritek" },
                            new Stock {StockID=3, Name = "Akamai" },
                            new Stock {StockID=4, Name="Baidu" },
                            new Stock {StockID=5, Name = "Blinkx" },
                            new Stock {StockID= 6, Name="Blucora "},
                            new Stock {StockID=7, Name="Boingo" },
                            new Stock {StockID=8, Name  ="Brainybrawn" },
                            new Stock {StockID=9, Name ="Carbonite" },
                            new Stock {StockID=10, Name ="China Finance" },
                            new Stock {StockID=11, Name ="ChinaCache" },
                            new Stock {StockID=12, Name = "ADR" },
                            new Stock {StockID=13, Name = "ChitrChatr" },
                            new Stock {StockID=14, Name = "Cnova" },
                            new Stock {StockID=15, Name = "Cogent" },
                            new Stock {StockID=16, Name = "Crexendo" },
                            new Stock {StockID=17, Name = "CrowdGather" },
                            new Stock {StockID=18, Name = "EarthLink" },
                            new Stock {StockID=19, Name = "Eastern" },
                            new Stock {StockID=20, Name = "ENDEXX" },
                            new Stock {StockID=21, Name = "Envestnet" },
                            new Stock {StockID=22, Name = "Epazz" },
                            new Stock {StockID=23, Name = "FlashZero" },
                            new Stock {StockID=24, Name = "Genesis" },
                            new Stock {StockID=25, Name = "InterNAP" },
                            new Stock {StockID=26, Name = "MeetMe" },
                            new Stock {StockID=27, Name = "Netease" },
                            new Stock {StockID=28, Name = "Qihoo" }
          }.ForEach(s => context.Stock.Add(s));

            Broker broker = new Broker
            {
                BrokerID = 1,
                Name = "Broker",
                Persons = new List<Person>
                {
                    new Person {PersonID =1, Name = "Person 1" },
                    new Person {PersonID =2, Name = "Person 2" }
                }
            };

            context.Broker.Add(broker);
            context.SaveChanges();
        } 

    } // end class SampleData
}