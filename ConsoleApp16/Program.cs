using System;

namespace ConsoleApp16 {
    internal class Program {
        static void Main(string[] args) {
            CreateStudent();
            ManageProducts();
        }

        #region Task1

        static void CreateStudent() {
            Console.Write("Enter the fullname for student: ");
            string fullname = Console.ReadLine();

            Console.Write("Enter the point for the student: ");
            double.TryParse(Console.ReadLine(), out double point);

            Console.Write("Enter the group number for the student: ");
            string groupNo = Console.ReadLine();

            Console.Write("Enter the birth date for the student: ");
            DateTime.TryParse(Console.ReadLine(), out DateTime birthDate);

            Student std1 = new Student(fullname, point, groupNo, birthDate);
            std1.ShowInfo();
        }

        #endregion

        #region Task2

        static void ManageProducts() {
            Console.Write("Please enter that how many product do you want to create: ");
            byte.TryParse(Console.ReadLine(), out byte count);
            Product[] products = new Product[count];
            for (int i = 0; i < count; i++) {
                Console.Write($"Please enter the name of the product {i + 1}: ");
                string name = Console.ReadLine();
                Console.Write($"Please enter the price of the product {i + 1}: ");
                double.TryParse(Console.ReadLine(), out double price);
                products[i] = new Product(name, price);
            }
            Console.WriteLine($"Average Price is: {FindAveragePrice(products).ToString("0.00")}");
            Console.WriteLine($"The cheapest product is: {FindTheCheapestProduct(products)}");
            Console.WriteLine($"The most expensive product is: {FindTheMostExpensiveProduct(products)}");
        }

        static double FindAveragePrice(Product[] products) {
            double sumOfPrices = 0;

            for (int i = 0; i < products.Length; i++) {
                sumOfPrices += products[i].Price;
            }

            return sumOfPrices / products.Length;
        }

        static string FindTheCheapestProduct(Product[] products) {
            int minPriceIndex = 0;

            for (int i = 0; i < products.Length; i++) {
                if (products[i].Price < products[minPriceIndex].Price)
                    minPriceIndex = i;
            }

            return products[minPriceIndex].Name;
        }

        static string FindTheMostExpensiveProduct(Product[] products) {
            int maxPriceIndex = 0;

            for (int i = 0; i < products.Length; i++) {
                if (products[i].Price > products[maxPriceIndex].Price)
                    maxPriceIndex = i;
            }

            return products[maxPriceIndex].Name;
        }

        #endregion
    }
}
