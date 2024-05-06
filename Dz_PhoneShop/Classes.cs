using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_PhoneShop
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Number { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Client Client { get; set; }
        public List<Product> Products { get; set; }
    }
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
