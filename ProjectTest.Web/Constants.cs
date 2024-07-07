using ProjectTest.Web.Models;

namespace ProjectTest.Web;

public static class Constants
{

    public static IEnumerable<Employee> Employees = new List<Employee>
    {
        new("John Doe", "E001", 123456789, 2222341234, "Mississauga", 50000.542m, "Canada" ),
        new("Jane Smith", "E002", 987654321, 3333452345, "Toronto", 60000.739m, "USA" ),
        new("Emily Johnson", "E003", 234567891, 4445567890, "Mississauga", 51000.266m, "Canada" ),
        new("Michael Thompson", "E004", 345678912, 5556678901, "Mississauga", 52000.697m, "Canada" ),
        new("Sarah Williams", "E005", 456789123, 6667789012, "Mississauga", 53000.827m, "Canada" ),
        new("David Brown", "E006", 567891234, 7778890123, "Mississauga", 54000.952m, "Canada" ),
        new("Alex Daniel", "E007", 678912345, 8889901234, "Matanzas", 56000.411m, "Cuba" )
    };
}