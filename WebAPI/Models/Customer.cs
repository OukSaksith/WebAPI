namespace WebAPI.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
