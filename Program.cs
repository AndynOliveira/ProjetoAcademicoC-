using ExercicioDeFixacao.Entities;
using ExercicioDeFixacao.Entities.Enums;
using System;
using System.Reflection.Metadata.Ecma335;

namespace ExercicioDeFixacao {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            DateTime birthDate = DateTime.Now;
            Console.WriteLine("Birth date: " + birthDate);

            Client client= new Client(name,email,birthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order (birthDate,status,client);

            Console.WriteLine("How many items to this order: ");
            int n = int.Parse (Console.ReadLine());
            
            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Enter #" + i + " item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quatity: ");
                int quatity = int.Parse (Console.ReadLine());

                
                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quatity, productPrice, product);
                order.AddItem (orderItem);
            }

            Console.WriteLine("\n" + order);

            
        }
    }
}