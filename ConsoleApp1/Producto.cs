using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Producto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int Quantity { get; set; }
        public Producto(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return $"{Name} - {Price:C} x {Quantity}";
        }
        public decimal TotalPrice()
        {
            return Price * Quantity;
        }
        public void Display()
        {
            Console.WriteLine(this);
        }
        public static Producto Create(string name, decimal price, int quantity)
        {
            return new Producto(name, price, quantity);
        }
        public static Producto Create(string name, decimal price)
        {
            return new Producto(name, price, 1);
        }
    }
}
