using System.Collections.Generic;
using System.Threading.Tasks;
using MyNewProject.Domain.Orders;

namespace MyNewProject.Data.Orders
{
    public interface IOrdersSource
    {
        Task<IReadOnlyList<Order>> GetAll();
    }
}