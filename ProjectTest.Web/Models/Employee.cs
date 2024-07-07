namespace ProjectTest.Web.Models
{
    public class Employee
    {
        public string FullName { get; set; } = string.Empty;
        public string EmployeeID { get; set; } = string.Empty;
        public decimal SIN { get; set; }
        public decimal PhoneNumber { get; set; }
        public string City { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public string Country { get; set; } = string.Empty;
    }
}

