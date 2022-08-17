using Course.Entities;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities.Enums;

List<OrderItem> items = new List<OrderItem>();

Console.WriteLine("Enter client data: ");
Console.Write("Name: ");
var name = Console.ReadLine();
Console.Write("Email: ");
var email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());

var client = new Client(name, email, birthDate);

Console.WriteLine("Enter order data:");
Console.Write("Status: ");
var status = Enum.Parse<OrderStatus>(Console.ReadLine());

Order order = new Order(DateTime.Now, status, client);

Console.Write("How many items to this order? ");
var n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} item data: ");
    Console.Write("Product: ");
    var productName = Console.ReadLine();
    Console.Write("Price: ");
    var productPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    Product product = new Product(productName, productPrice);

    Console.Write("Quantity: ");
    var productQuantity = int.Parse(Console.ReadLine());

    OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);

    order.AddItem(orderItem);

}

Console.WriteLine(order);
