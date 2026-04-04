using System;
using System.Collections.Generic;

class Program
{
    static Queue<Order> orderQueue = new Queue<Order>();
    static int orderCounter = 1;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Delicious Churros ---");
            Console.WriteLine("1 Place Order");
            Console.WriteLine("2 Deliver Order");
            Console.WriteLine("0 Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PlaceOrder();
                    break;

                case 2:
                    DeliverOrder();
                    break;

                case 0:
                    return;
            }
        }
    }

    static void PlaceOrder()
    {
        Console.WriteLine("1 Plain Sugar (€6)");
        Console.WriteLine("2 Cinnamon Sugar (€6)");
        Console.WriteLine("3 Chocolate Sauce (€8)");
        Console.WriteLine("4 Nutella (€8)");

        int option = int.Parse(Console.ReadLine());

        Console.Write("Quantity: ");
        int qty = int.Parse(Console.ReadLine());

        string name = "";
        double price = 0;

        switch (option)
        {
            case 1: name = "Plain Sugar"; price = 6; break;
            case 2: name = "Cinnamon Sugar"; price = 6; break;
            case 3: name = "Chocolate Sauce"; price = 8; break;
            case 4: name = "Nutella"; price = 8; break;
        }

        Order order = new Order(orderCounter++, name, qty);
        double total = order.PayBill(price);

        orderQueue.Enqueue(order);

        Console.WriteLine($"Order placed. Order Number: {order.OrderNo}");
        Console.WriteLine($"Total Bill: €{total}");
    }


    static void DeliverOrder()
    {
        if (orderQueue.Count == 0)
        {
            Console.WriteLine("No orders waiting.");
            return;
        }

        Order order = orderQueue.Dequeue();
        order.CollectOrder();
    }
}