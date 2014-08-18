using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;







[Schema("Person")]
[Alias("Address")]
class Address
{
    public int AddressID { get; set; }
    public String City { get; set; }
    public string AddressLine1 { get; set; }

}

[Schema("Person")]
[Alias("EmailAddress")]
class Email
{
    [References(typeof(Person))]
    public int BusinessEntityID { get; set; }

    public string EmailAddress { get; set; }

}
[Schema("Person")]
[Alias("Password")]
class Password
{
    [References(typeof(Person))]
    public int BusinessEntityID { get; set; }
    public string PasswordHash { get; set; }
}

[Schema("Person")]
[Alias("Person")]
class Person
{
    [AutoIncrement]
    public int BusinessEntityID { get; set; }
    public string FirstName { get; set; }

}

[Schema("HumanResources")]
[Alias("Shift")]
public class Shift
{
    [AutoIncrement]
    public int ShiftID { get; set; }
    public string Name { get; set; }
}
[Schema("HumanResources")]
[Alias("EmployeeDepartmentHistory")]
public class EmployeeDepartmentHistory
{
    [References(typeof(Person))]
    public int BusinessEntityID { get; set; }
    [References(typeof(Shift))]
    public int ShiftID { get; set; }
    [AutoIncrement]
    public int DepartmentID { get; set; }


}
[Schema("Production")]
[Alias("ProductCostHistory")]
public class product
{
    [AutoIncrement]
    public int ProductID { get; set; }
    public double StandardCost { get; set; }
}
[Schema("HumanResources")]
[Alias("Employee")]
public class Employee
{
    [AutoIncrement]
    public int BusinessEntityID { get; set; }
    

}
[Schema("Production")]
[Alias("Product")]
public class products
{
    public string Name { get; set; }
    public string Color { get; set; }

    public int SafetyStockLevel { get; set; }

}
[Schema("Production")]
[Alias("ProductInventory")]
public class ProductInventory
{
    public int ProductID { get; set; }
    public int Quantity { get; set; }

    public int LocationID {get; set;}
}