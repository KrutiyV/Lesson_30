using SQLHomework4;

public class Program
{
    public static void Main(string[] args)
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            Employees employee1 = new Employees { Name = "Matt", Position = "Guard" };
            //it would be better to give name Employee to single entity class to avoid misunderstanding between single Employees item and multiple Employees items
            Employees employee2 = new Employees { Name = "Anthony", Position = "Manager" };
            Employees employee3 = new Employees { Name = "Kate", Position = "CEO" };

            Customers customer1 = new Customers { Name = "Bob", Age = 45, Email ="bob@gmail.com" };
            Customers customer2 = new Customers { Name = "Hanna", Age = 20, Email = "hanna@gmail.com" };
            Customers customer3 = new Customers { Name = "Max", Age = 25, Email = "max@gmail.com" };

            Products product1 = new Products { ProductName = "iPhone", Count = 2 };
            Products product2 = new Products { ProductName = "Samsung", Count = 20 };
            Products product3 = new Products { ProductName = "Nokia", Count = 5 };

            Orders order1 = new Orders { CustomerName = "Bob", ItemName = "iPhone", SellerName = "Anthony", Date = "08.09.22" };
            Orders order2 = new Orders { CustomerName = "Hanna", ItemName = "Samsung", SellerName = "Anthony", Date = "07.09.22" };
            Orders order3 = new Orders { CustomerName = "Max", ItemName = "Nokia", SellerName = "Anthony", Date = "06.09.22" };


            db.Employees.Add(employee1);
            db.Employees.Add(employee2);
            db.Employees.Add(employee3);
            db.Customers.Add(customer1);
            db.Customers.Add(customer2);
            db.Customers.Add(customer3);
            db.Products.Add(product1);
            db.Products.Add(product2);
            db.Products.Add(product3);
            db.Orders.Add(order1);
            db.Orders.Add(order2);
            db.Orders.Add(order3);
            db.SaveChanges();
            Console.WriteLine("Objects saved");

            Console.WriteLine("Objects in <Employees> list:");
            var employees = db.Employees.ToList();
            foreach (Employees e in employees)
            {
                Console.WriteLine($"{e.Id}.{e.Name}.{e.Position}");
            }
            Console.WriteLine("Objects in <Customers> list:");
            var customers = db.Customers.ToList();
            foreach (Customers c in customers)
            {
                Console.WriteLine($"{c.Id}.{c.Name}.{c.Age}.{c.Email}");
            }
            Console.WriteLine("Objects in <Products> list:");
            var products = db.Products.ToList();
            foreach (Products p in products)
            {
                Console.WriteLine($"{p.Id}.{p.ProductName}.{p.Count}");
            }
            Console.WriteLine("Objects in <Orders> list:");
            var orders = db.Orders.ToList();
            foreach (Orders o in orders)
            {
                Console.WriteLine($"{o.CustomerName}.{o.ItemName}.{o.SellerName}.{o.Date}");
            }
        }
        Console.Read();
    }
}
//checked
