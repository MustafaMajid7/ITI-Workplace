using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    internal class Product : IComparable<Product>
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(int id,string name,double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID : {Id}, Name : {Name}, Price {Price}";
        }

        public int CompareTo(Product other)
        {
            if(this.Price > other.Price)
                return 1;
            if (this.Price < other.Price)
                return -1;
            return 0;
        }
    }
}
