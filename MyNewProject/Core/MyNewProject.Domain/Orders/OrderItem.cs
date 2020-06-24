namespace MyNewProject.Domain.Orders
{
    public class OrderItem
    {
        public OrderItem() { }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public ItemStatus ItemStatus { get; set; }
    }
}