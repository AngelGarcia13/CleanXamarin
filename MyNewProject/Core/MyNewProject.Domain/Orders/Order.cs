using System;
using System.Collections.Generic;

namespace MyNewProject.Domain.Orders
{
    public class Order
    {
        public Order(){ }

        public string OrderId { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public string BarcodeURL { get; set; }
        public DeliveryMethod DeliveryMethod { get; set; }
        public string DeliveryTime { get; set; }
        public List<OrderItem> Items { get; set; }
    }
}
