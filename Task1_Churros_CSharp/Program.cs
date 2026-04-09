using System;
using System.Collections.Generic;


public class Order
{
    public int order_no;
    public string order_details;
    public int quantity;
    public double bill;

    private static int counter = 1000;

    public Order(string details, int qty)
    {
        order_no = ++counter;
        order_details = details;
        quantity = qty;
    }

    public double pay_bill(double price)
    {
        bill = price * quantity;
        return bill;
    }

    public void collect_order()
    {
        Console.WriteLine("Order delivered: {0}", order_no);
    }
}

class QueueDemo
{
    public static void Main(string[] args)
    {
        Queue<Order> orders = new Queue<Order>();

        while (true)
        {
            Console.WriteLine("\n- - - Delicious Churros - - -");
            Console.WriteLine("1. Place Order");
            Console.WriteLine("2. Deliver Order");
            Console.WriteLine("0. Exit");

            int choice = int.Parse(Console.ReadLine()!);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nMenu:");
                    Console.WriteLine("1. Plain Sugar (€6)");
                    Console.WriteLine("2. Cinnamon Sugar (€6)");
                    Console.WriteLine("3. Chocolate Sauce (€8)");
                    Console.WriteLine("4. Nutella (€8)");

                    Console.Write("Choose option: ");
                    int option = int.Parse(Console.ReadLine()!);

                    Console.Write("Enter quantity: ");
                    int qty = int.Parse(Console.ReadLine()!);

                    string name = "";
                    double price = 0;

                    switch (option)
                    {
                        case 1: name = "Plain Sugar"; price = 6; break;
                        case 2: name = "Cinnamon Sugar"; price = 6; break;
                        case 3: name = "Chocolate Sauce"; price = 8; break;
                        case 4: name = "Nutella"; price = 8; break;
                        default:
                            Console.WriteLine("Invalid option");
                            continue;
                    }

                    Order o = new Order(name, qty);
                    double total = o.pay_bill(price);

                    orders.Enqueue(o);

                    Console.WriteLine("Order placed successfully!");
                    Console.WriteLine("Order Number: {0}", o.order_no);
                    Console.WriteLine("Total Bill: €{0}", total);
                    break;

                case 2:
                    if (orders.Count == 0)
                    {
                        Console.WriteLine("No orders in queue.");
                    }
                    else
                    {
                        Order ord = orders.Dequeue();
                        ord.collect_order();
                    }
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}