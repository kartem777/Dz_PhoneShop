
using Dz_PhoneShop;

internal class Program
{
    static void Main(string[] args)
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            var c1 = new Client { Name = "John", Email = "john@example.com", Age = 27 };
            var c2 = new Client { Name = "Alice", Email = "alice@example.com", Age = 19 };
            var p1 = new Product { Name = "iPhone 15", Description = "Latest model", Price = 1700, Number = 10 };
            var p2 = new Product { Name = "Samsung Galaxy S24", Description = "Samsung", Price = 1300, Number = 15 };
            var o = new Order
            {
                OrderDate = DateTime.Now,
                Client = c1,
                Products = new List<Product> { p1, p2, p1 }
            };
            db.Clients.Add(c1);
            db.Clients.Add(c2);
            db.Products.Add(p1);
            db.Products.Add(p2);
            db.Orders.Add(o);
            db.SaveChanges();
            var clients = db.Clients.ToList();
            var products = db.Products.ToList();
            var orders = db.Orders.ToList();
            foreach(Client c in clients) Console.WriteLine($"{c.Id} -> {c.Name} {c.Email} {c.Age}");
            foreach(Product p in products) Console.WriteLine($"{p.Id} -> {p.Name} {p.Description} {p.Price} {p.Number}");
            foreach(Order ord in orders)
            {
                Console.WriteLine($"{ord.Id} -> {ord.OrderDate} {ord.Client.Name}");
                foreach(Product p in ord.Products)
                {
                    Console.WriteLine(p.Name);
                }
            }
        }
    }
}
