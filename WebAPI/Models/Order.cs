namespace WebAPI.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }

        //public Customer Customer { get; set; }
        //public Employee Employee { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
