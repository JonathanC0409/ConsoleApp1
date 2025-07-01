using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Tienda
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Producto> Productos { get; set; }
        public Tienda(int id, string name)
        {
            Id = id;
            Name = name;
            Productos = new List<Producto>();
        }
        public void AddProducto(Producto producto)
        {
            Productos.Add(producto);
        }
        public void RemoveProducto(Producto producto)
        {
            Productos.Remove(producto);
        }
        public void DisplayProductos()
        {
            Console.WriteLine($"Productos in {Name}:");
            foreach (var producto in Productos)
            {
                producto.Display();
            }
        }
        public decimal TotalSales()
        {
            return Productos.Sum(p => p.TotalPrice());
        }
        public override string ToString()
        {
            return $"{Name} (ID: {Id}) - Total Sales: {TotalSales():C}";
        }
        public static Tienda Create(int id, string name)
        {
            return new Tienda(id, name);
        }
    }
}
