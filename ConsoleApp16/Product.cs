using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16 {
    internal class Product {

        public Product(string name) {
            Name = name;
        }
        public Product(string name, double price) : this(name) {
            Price = price;
        }

        public string Name;
        public double Price;
    }
}
