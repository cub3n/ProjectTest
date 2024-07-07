namespace ProjectTest.Web.Models
{
    public class Employee
    {
        public Employee(string fullName, string employeeID, decimal sin, decimal phoneNumber, string city, decimal salary, string country)
        {
            FullName = fullName;
            EmployeeID = employeeID;
            SIN = sin;
            PhoneNumber = phoneNumber;
            City = city;
            Salary = salary;
            Country = country;
        }

        public string FullName { get; set; } = string.Empty;
        public string EmployeeID { get; set; } = string.Empty;
        public decimal SIN { get; set; }
        public decimal PhoneNumber { get; set; }
        public string City { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public string Country { get; set; } = string.Empty;
    }
}
