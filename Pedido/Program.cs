using System;
using Pedido.Entities.Enum;
using Pedido.Entities;
using System.Globalization;

namespace Pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Client c1 = new Client(name, email, birthdate);
            Console.WriteLine("Enter order data: ");
            Console.Write("Status (PedingPayment|Processing|Shipped|Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, c1);
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string prodname = Console.ReadLine();
                Console.Write("Produtct price: ");
                double prodprice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(prodname, prodprice);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantity, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMARY:");
            Console.WriteLine($"Order moment: {order.Moment}");
            Console.WriteLine($"Order Status: {order.Status}");
            Console.WriteLine($"Client: {order.Client.Name} ({order.Client.BirthDate}) - {order.Client.Email}");
            Console.WriteLine("Order Items:");
            foreach(OrderItem item in order.Item)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Total Price: $" + order.Total().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
