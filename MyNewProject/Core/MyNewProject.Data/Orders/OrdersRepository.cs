using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyNewProject.Domain.Orders;

namespace MyNewProject.Data.Orders
{
    public class OrdersRepository
    {
        private IOrdersSource _ordersSource;

        public OrdersRepository(IOrdersSource ordersSource)
        {
            _ordersSource = ordersSource;
        }
        public async Task<IReadOnlyList<Order>> GetOrdersAsync()
        {
            return await _ordersSource.GetAll();
        }
    }
}
