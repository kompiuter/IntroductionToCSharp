using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleThree
{
    class LINQExample
    {
        public static void Run()
        {
            // Standard Query Operators
            // 1 - Selecting properties from a collection
            //var customers = from cust
            //                in company.Customers
            //                select cust.Name;

            //foreach (var customer in customers)
            //    Console.WriteLine(customer);

            // 2 - Filtering data in a collection
            //var customers = from cust
            //                in company.Customers
            //                where cust.Name.Length > 4 && !cust.Name.StartsWith("J")
            //                select cust;

            //foreach (var customer in customers)
            //    Console.WriteLine(customer.Name);

            // 3 - Ordering collections
            //var customers = from cust
            //                in company.Customers
            //                orderby cust.Name descending
            //                select cust.Name;

            //foreach (var customer in customers)
            //    Console.WriteLine(customer);

            //// 4 - Joining collections
            //var custOrders = from cust in company.Customers
            //                 join ord in company.Orders
            //                    on cust.ID equals ord.CustomerID
            //                 select new
            //                 {
            //                     Customer = cust.Name,
            //                     Item = ord.Description
            //                 };

            //foreach (var custOrd in custOrders)
            //    Console.WriteLine($"{custOrd.Customer} bought {custOrd.Item}");

            //// Language Syntax Equivalent
            //// 5 - Select
            //var customers = company.Customers.Select(c => c.Name);
            //foreach (var customer in customers)
            //    Console.WriteLine(customer);

            //// 6 - Where
            //var customers = company.Customers.Where(c => c.Name.StartsWith("J"));
            //foreach (var customer in customers)
            //    Console.WriteLine(customer.Name);

            //// 7 - Combining collections with Union & then ordering
            //var additionalCustomers = new List<Customer>
            //{
            //    new Customer { ID = 4, Name = "Zoe" },
            //    new Customer { ID = 5, Name = "Gary" }
            //};

            //var allCustomers = company.Customers.Union(additionalCustomers)
            //                                    .OrderByDescending(c => c.Name)
            //                                    .Select(c => c.Name);

            //foreach (var customer in allCustomers)
            //    Console.WriteLine(customer);
        }
        
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Order
    {
        public int CustomerID { get; set; }
        public string Description { get; set; }
    }

    public class Company
    {
        public Company()
        {
            Customers = new List<Customer>
            {
                new Customer { ID=0, Name = "John" },
                new Customer { ID=1, Name = "Audrey" },
                new Customer { ID=2, Name = "Jennifer" }
            };
            Orders = new List<Order>
            {
                new Order { CustomerID = 0, Description = "Shoes" },
                new Order { CustomerID = 1, Description = "Earphones" },
                new Order { CustomerID = 2, Description = "Skirt" },
            };
        }

        public List<Customer> Customers { get; set; }
        public List<Order> Orders { get; set; }
    }
}
