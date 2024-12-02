using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HWConstructDeconstruct
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        // Конструктор по умолчанию
        public Product() { }

        // Конструктор с параметрами
        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        // Деконструктор
        public void Deconstruct(out string name, out decimal price, out int quantity)
        {
            name = Name;
            price = Price;
            quantity = Quantity;
        }

    }
    


}
