namespace WebAPI.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
