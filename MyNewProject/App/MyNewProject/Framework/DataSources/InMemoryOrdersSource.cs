using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyNewProject.Data.Orders;
using MyNewProject.Domain.Orders;

namespace MyNewProject.Framework.DataSources
{
    public class InMemoryOrdersSource: IOrdersSource
    {
        public async Task<IReadOnlyList<Order>> GetAll()
        {
            await Task.Delay(1000);
            return new List<Order>
            {
                    new Order
                    {
                        OrderId = "A001",
                        DeliveryTime = DateTime.Now.ToShortDateString()
                    },
                    new Order
                    {
                        OrderId = "A002",
                        DeliveryTime = DateTime.Now.ToShortDateString()
                    },
                    new Order
                    {
                        OrderId = "A003",
                        DeliveryTime = DateTime.Now.ToShortDateString()
                    },
                    new Order
                    {
                        OrderId = "A004",
                        DeliveryTime = DateTime.Now.ToShortDateString()
                    },
                    new Order
                    {
                        OrderId = "A005",
                        DeliveryTime = DateTime.Now.ToShortDateString()
                    },
                    new Order
                    {
                        OrderId = "A006",
                        DeliveryTime = DateTime.Now.ToShortDateString()
                    },
                    new Order
                    {
                        OrderId = "A007",
                        DeliveryTime = DateTime.Now.ToShortDateString()
                    },
                    new Order
                    {
                        OrderId = "A008",
                        DeliveryTime = DateTime.Now.ToShortDateString()
                    },
                    new Order
                    {
                        OrderId = "A009",
                        DeliveryTime = DateTime.Now.ToShortDateString()
                    }
            };
        }
    }
}
