using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyNewProject.Data.Orders;
using MyNewProject.Domain.Orders;

namespace MyNewProject.UseCases.Orders
{
    public class GetCurrentUserOrders
    {
        private OrdersRepository _ordersRepository;

        public GetCurrentUserOrders(OrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public Task<IReadOnlyList<Order>> Invoke()
        {
            return _ordersRepository.GetOrdersAsync();
        }
    }
}
