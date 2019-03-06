using ClassLibrary;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //add some code 
            //added something in Master branch

            Account acc1 = new Account("acc1", "John Smith");

            Product p1 = new Product("p1", "Dog food", 0.5, 1.7);
            Product p2 = new Product("p2", "Fork", 2.0, 2.8);

            LineItem lineItem1 = new LineItem();
            lineItem1.Id = 1;
            lineItem1.Product = p1;
            lineItem1.Quantity = 2;

            LineItem lineItem2 = new LineItem(2, p2, 1);
            //lineItem2.Id = 2;
            //lineItem2.Product = p2;
            //lineItem2.Quantity = 1;

            List<LineItem> lineItems = new List<LineItem>();
            lineItems.Add(lineItem1);
            lineItems.Add(lineItem2);

            Order order1 = new Order();
            order1.Account = acc1;
            order1.OrderId = 1;
            order1.Date = DateTime.Now;
            order1.LineItems = lineItems;

            Order order2 = new Order(2, DateTime.Now, acc1, lineItems, OrderStatus.Dispatched);

            Order order3 = new Order();
            order3.OrderStatus = OrderStatus.Dispatched;
            order3.Account = acc1;
            order3.OrderId = 3;
            order3.Add(p1, 2);
            order3.Add(p2, 1);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
